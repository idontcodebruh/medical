﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
namespace medical
{
    public partial class medicalviewer : Form
    {
        public medicalviewer()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        public string global_nom;
        public string global_prénom;
        string[] found_dates = new string[30];
        string[] mapped_poids = new string[30];
        string[] mapped_taille = new string[30];
        int current_index = 0;
        int[] mapped_index = new int[30];
        public void Load_Patient()
        { /* LOAD PATIENT NAME INTO GLOBAL VARS */
            bool isFirstReadDone = false;
            var lines = File.ReadLines("C:\\Users\\belha\\source\\repos\\medical\\medical\\bin\\Debug\\current_patient.txt");
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
        private void medicalviewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Examens' table. You can move, or remove it, as needed.
            this.examensTableAdapter.Fill(this.mALADES4DataSet.Examens);
            Load_Patient();
            if (String.IsNullOrEmpty(global_nom) || String.IsNullOrEmpty(global_prénom))
            {
                MessageBox.Show("No patient was loaded.");
                return;
            }
            loadname.Text = global_nom + "-" + global_prénom;
            Load_Dates();
        }
        /* Load_Dates():
         * Arguments : None
         * Functionality : Loads all examination dates for target patient
         */
        public void Load_Dates()
        {
            int j = 0;
            Array.Clear(found_dates, 0, 30);
            Array.Clear(mapped_index, 0, 30);
            Array.Clear(mapped_poids, 0, 30);
            Array.Clear(mapped_taille, 0, 30);
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                if(selectedRow.Cells[0].Value.ToString() ==global_nom && selectedRow.Cells[1].Value.ToString() == global_prénom)
                {
                    // Lazy attempt to avoid doing more searching as to optimize time
                    loadnaissance.Text = selectedRow.Cells[3].Value.ToString();
                    found_dates[j] = selectedRow.Cells[4].Value.ToString();
                    mapped_poids[j] = selectedRow.Cells[11].Value.ToString();
                    mapped_taille[j] = selectedRow.Cells[9].Value.ToString();
                    mapped_index[j] = i;
                    j++;

                }

            }
            /*
             * Now we populate the dropdown for date courante
             * This will be useful for navigating throughout the examination files with ease
             */
            
            bunifuDropdown1.Items.Clear();
            for (int i = 0; i < j; i++)
            {
                bunifuDropdown1.Items.Add(found_dates[i].ToString());
            }
        }
        /* 
         * This function would be useful as it is interactive and would perform changes based SelectedIndex.
         */
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_index = bunifuDropdown1.SelectedIndex;
            loadpoids.Text = mapped_poids[bunifuDropdown1.SelectedIndex];
            loadtaille.Text = mapped_taille[bunifuDropdown1.SelectedIndex];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }
        public void UpdateData()
        {

            con.Open();
            string curr_poids = loadpoids.Text;
            string curr_taille = loadtaille.Text;
            string curr_date_courante = found_dates[current_index];
            MessageBox.Show(curr_poids + " " + Convert.ToDateTime(curr_date_courante).ToShortDateString());
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Examens set poids='" +Convert.ToDecimal(curr_poids) + "'where nom='" + global_nom+ "' AND prénom ='" + global_prénom+ "' AND date_courante='" + Convert.ToDateTime(curr_date_courante).ToShortDateString() +"'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Examens set taille='" + Convert.ToDecimal(curr_taille) + "'where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante='" + Convert.ToDateTime(curr_date_courante).ToShortDateString() + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            refreshData();
            Load_Dates(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void refreshData()
        {

            /* REFRESH DATA */
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "select * from Examens";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(cmd);
            dataAdapter1.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();
            /* REFRESH DATA */

        }
    }
}