using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace medical
{
    public partial class appointmentform : Form
    {
        public string global_nom = "";
        public string global_prénom = "";
        void Load_Patient()
        { /* LOAD PATIENT NAME INTO GLOBAL VARS */
            bool isFirstReadDone = false;
            var lines = File.ReadLines("current_patient.txt");
            foreach (var line in lines)
            {
                if (!isFirstReadDone)
                {
                    global_nom = line;
                    isFirstReadDone = true;
                }
                else
                {
                    global_prénom = line;
                }

            }

        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appointment.accdb"));
        public appointmentform()
        {
            InitializeComponent();

        }

        private void appointmentform_Load(object sender, EventArgs e)
        {

            Load_Patient();
            fullNameText.Text = global_nom + "-" + global_prénom;
            /*
             * Load current appointments into the grid
             */

            finalGrid.Rows.Clear();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                finalGrid.Rows.Add(reader.GetValue(1).ToString(),reader.GetValue(2).ToString(),reader.GetValue(3).ToString(), reader.GetValue(5).ToString());
            }
            reader.Close();
            con.Close();
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
                
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                 
                string nom_child;
                string prénom_child;
                string priority;
                nom_child = finalGrid.SelectedRows[0].Cells[1].Value.ToString();
                prénom_child = finalGrid.SelectedRows[0].Cells[2].Value.ToString();
                priority = finalGrid.SelectedRows[0].Cells[4].Value.ToString();
                fullNameText.Text = nom_child + "-" + prénom_child;
                global_nom = nom_child;
                global_prénom = prénom_child;
                bunifuDatePicker1.Checked = true;
                bunifuDatePicker1.Value = Convert.ToDateTime(finalGrid.SelectedRows[0].Cells[3].Value.ToString());

            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string status = "Unknown";
                cmd.CommandText = "insert into Table1 (nom,prénom,date_app,priority,status) values ('" + global_nom + "','" + global_prénom + "','" + bunifuDatePicker1.Value.ToString("MM/dd/yyyy") + "','" + "Low" + "','" + status + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yes");
                con.Close();
                refreshData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string nom;
            string prénom;
            string date_app;
            int ID = 0;
            string mark = "Annulé";
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                nom = finalGrid.SelectedRows[0].Cells[0].Value.ToString();
                prénom = finalGrid.SelectedRows[0].Cells[1].Value.ToString();
                date_app = finalGrid.SelectedRows[0].Cells[2].Value.ToString();
                // Perform a search to determine ID
                con.Open();
                cmd.CommandText = "select * from Table1 where nom='" + nom + "' AND prénom ='" + prénom + "' AND date_app ='" + date_app + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetInt32(0);
                    MessageBox.Show(ID.ToString());
                }
                reader.Close();
                con.Close();
                con.Open();
                cmd.CommandText = "update Table1 set status = '" + mark + "' where ID=" + ID;
                cmd.ExecuteNonQuery();
                con.Close();
                refreshData();
            }
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            string nom;
            string prénom;
            string date_app;
            int ID=0;
            string mark = "Traité";
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                
                nom = finalGrid.SelectedRows[0].Cells[0].Value.ToString();
                prénom = finalGrid.SelectedRows[0].Cells[1].Value.ToString();
                date_app = finalGrid.SelectedRows[0].Cells[2].Value.ToString();
                // Perform a search to determine ID
                con.Open();
                cmd.CommandText = "select * from Table1 where nom='" + nom + "' AND prénom ='" + prénom + "' AND date_app ='" + date_app + "'";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ID = reader.GetInt32(0);
                    MessageBox.Show(ID.ToString());
                }
                reader.Close();
                con.Close();
                con.Open();
                cmd.CommandText = "update Table1 set status = '" + mark + "' where ID=" + ID;
                cmd.ExecuteNonQuery();
                con.Close();
                refreshData();
            }
        }
        public void refreshData() {
            finalGrid.Rows.Clear();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                finalGrid.Rows.Add(reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(5).ToString());
            }
            reader.Close();
            con.Close();

        }

        private void addAppBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            string status = "Unknown";
            cmd.CommandText = "insert into Table1 (nom,prénom,date_app,priority,status) values ('" + bunifuTextBox1.Text + "','" + bunifuTextBox2.Text + "','" + bunifuDatePicker2.Value.ToString("MM/dd/yyyy") + "','" + "Low" + "','" + status + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Yes");
            con.Close();
            refreshData();
        }
    }
}
