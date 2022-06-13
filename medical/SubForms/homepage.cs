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
    public partial class homepage : Form
    {

        public homepage()
        {
            InitializeComponent();

            
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Path.Combine("", "Logs.accdb"));
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "PARAMETRES.accdb"));
        OleDbConnection con2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "appointment.accdb"));
        private void homepage_Load(object sender, EventArgs e)
        {
            con1.Open();
            OleDbCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from correspondants";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDataGridView2.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString());
            }
            con1.Close();
            con.Open();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from Log";
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                bunifuDataGridView1.Rows.Add(reader1.GetValue(0).ToString(), reader1.GetValue(1).ToString());
            }
            con.Close();
            refreshData();
            doCalc();

        }
        public void doCalc()
        {
            int appointmentCounter = 0;
            int processedCounter = 0;
            int canceledCounter = 0;
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            date2 = DateTime.Now; // <-- Today's date
            /*
             * Update Appointments for today 
             *
             */
            con2.Open();
            OleDbCommand cmd = con2.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (DateTime.Compare(Convert.ToDateTime(Convert.ToDateTime(reader.GetValue(3).ToString()).ToShortDateString()),Convert.ToDateTime(date2.ToShortDateString())) == 0) {
                    appointmentCounter++;
                    if(reader.GetValue(4).ToString() == "Processed")
                    {
                        processedCounter++;
                    }
                    if(reader.GetValue(4).ToString()== "Canceled")
                    {
                        canceledCounter++;
                    }
                }
            }
            reader.Close();
            con2.Close();
            appointmentsToday.Text = "Total : " + appointmentCounter;
            canceledAppointments.Text = "Total : " + canceledCounter;
            processedAppointments.Text = "Total : " + processedCounter;

        }

        public void refreshData()
        {
            bunifuDataGridView1.Rows.Clear();
            /* REFRESH DATA */
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "select * from Log";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDataGridView1.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString());
            }
            con.Close();
            /* REFRESH DATA */

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(bunifuTextBox1.Text))
            {
                con1.Open();
                OleDbCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from correspondants";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunifuDataGridView2.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString());
                }
                reader.Close();
                con1.Close();
            }
            else
            {
                con1.Open();
                OleDbCommand cmd = con1.CreateCommand();
                cmd.CommandType = CommandType.Text;
                switch (bunifuDropdown1.SelectedIndex)
                {
                    case 0:
                        cmd.CommandText = "select * from correspondants where [Nom médecin]='" + bunifuTextBox1.Text + "'";
                        break;
                    case 1:
                        cmd.CommandText = "select * from correspondants where Prénom='" + bunifuTextBox1.Text + "'";
                        break;
                    case 2:
                        cmd.CommandText = "select * from correspondants where Spécialité='" + bunifuTextBox1.Text + "'";
                        break;
                    case 3:
                        cmd.CommandText = "select * from correspondants where Ville='" + bunifuTextBox1.Text + "'";
                        break;
                    case 4:
                        cmd.CommandText = "select * from correspondants where Wilaya='" + bunifuTextBox1.Text + "'";
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                }
                bunifuDataGridView2.Rows.Clear();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunifuDataGridView2.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString(), reader.GetValue(4).ToString(), reader.GetValue(5).ToString(), reader.GetValue(6).ToString(), reader.GetValue(7).ToString());
                }
                reader.Close();
                con1.Close();
            }
        }
    }
}
