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
            // TODO: This line of code loads data into the 'appointmentDataSet1.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.appointmentDataSet1.Table1);
            // TODO: This line of code loads data into the 'dataSet1.Table1' table. You can move, or remove it, as needed.
            Load_Patient();
            fullNameText.Text = global_nom + "-" + global_prénom;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string search_txt = searchBox.Text;
            if (String.IsNullOrEmpty(search_txt))
            {
                finalGrid.DataSource = table1BindingSource;
                return;
            }
            string strSearch = searchBox.Text;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            switch (bunifuDropdown1.SelectedIndex)
            {
                case 0: // NOM
                    cmd.CommandText = "select * from Table1 where nom LIKE '%" + strSearch + "%'";
                    break;
                case 1: // PRENOM
                    cmd.CommandText = "select * from Table1 where prénom LIKE '%" + strSearch + "%'";
                    break;
                case 2: // DATE APPOINTMENT
                    cmd.CommandText = "select * from Table1 where date_app ='" + strSearch + "'";
                    break;
                default:
                    break;
            }
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(dt);
            finalGrid.DataSource = dt;
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
                if (priority == "High")
                {
                    highRadio.Checked = true;
                }
                else {
                    lowRadio.Checked = true;
                }
            }

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string priority = "Low";
            if (highRadio.Checked == true) {
                priority = "High";
            }
            else {
                priority = "Low";
            }
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                string status = "Unknown";
                cmd.CommandText = "insert into Table1 (nom,prénom,date_app,priority,status) values ('" + global_nom + "','" + global_prénom + "','" + bunifuDatePicker1.Value.ToString("MM/dd/yyyy") + "','" + priority + "','" + status + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Yes");
                con.Close();
                refreshData();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                int ID;
                string mark = "Canceled";
                ID = Convert.ToInt32(finalGrid.SelectedRows[0].Cells[0].Value);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Table1 set status = '" + mark + "' where ID=" + ID;
                cmd.ExecuteNonQuery();
                con.Close();
                refreshData();
            }
        }

        private void markBtn_Click(object sender, EventArgs e)
        {
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                int ID;
                string mark = "Processed";
                ID = Convert.ToInt32(finalGrid.SelectedRows[0].Cells[0].Value);
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Table1 set status = '" + mark + "' where ID=" + ID;
                cmd.ExecuteNonQuery();
                con.Close();
                refreshData();
            }
        }
        public void refreshData() {

            /* REFRESH DATA */
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(cmd);
            dataAdapter1.Fill(dt1);
            finalGrid.DataSource = dt1;
            con.Close();
            /* REFRESH DATA */

        }
    }
}
