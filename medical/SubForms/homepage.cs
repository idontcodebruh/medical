﻿using System;
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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs.accdb"));
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PARAMETRES.accdb"));
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
            // TODO: This line of code loads data into the 'appointmentDataSet1.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.appointmentDataSet1.Table1);
            // TODO: This line of code loads data into the 'logsDataSet.Log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.logsDataSet.Log);
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
            date2 = DateTime.Now;
            dataGridView1.DataSource = table1BindingSource;
            /*
             * Update Appointments for today 
             *
             */
            for(int i =0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                date1 = Convert.ToDateTime(selectedRow.Cells[3].Value);
                if(DateTime.Compare(Convert.ToDateTime(date1.ToShortDateString()), Convert.ToDateTime(date2.ToShortDateString())) == 0)
                {
                    appointmentCounter++;
                    if (selectedRow.Cells[5].Value.ToString() == "Processed")
                    {
                        processedCounter++;
                    }
                    if (selectedRow.Cells[5].Value.ToString() == "Canceled")
                    {
                        canceledCounter++;
                    }
                }

            }
            appointmentsToday.Text = "Total : " + appointmentCounter;
            canceledAppointments.Text = "Total : " + canceledCounter;
            processedAppointments.Text = "Total : " + processedCounter;

        }

        public void refreshData()
        {

            /* REFRESH DATA */
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "select * from Log";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(cmd);
            dataAdapter1.Fill(dt1);
            bunifuDataGridView1.DataSource = dt1;
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
