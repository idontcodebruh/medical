using System;
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
    public partial class patientinfo : Form
    {
        public patientinfo()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string global_nom;
        string global_prénom;
        private void patientinfo_Load(object sender, EventArgs e)
        {
            Load_Patient();
            if(String.IsNullOrEmpty(global_nom) || String.IsNullOrEmpty(global_prénom))
            {
                MessageBox.Show("No patient was loaded.");
                this.Close();
            }
            readData();
        }
        public bool checkValidDate(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            return true;
        }
        public void readData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuTextBox1.Text = reader.GetString(0);
                bunifuTextBox2.Text = reader.GetString(1);
                if (checkValidDate(reader.GetValue(14).ToString()))
                {
                    bunifuDatePicker1.Value = Convert.ToDateTime(reader.GetValue(14).ToString());
                   
                }
                else
                {
                    MessageBox.Show("Patient has no valid date nassaince!");
                }
                if (checkValidDate(reader.GetValue(15).ToString()))
                {
                    bunifuDatePicker2.Value = Convert.ToDateTime(reader.GetValue(15).ToString());
                    
                }
                else
                {
                    MessageBox.Show("Patient has no prem date!");
                }
                bunifuTextBox3.Text = reader.GetString(9);
                bunifuTextBox4.Text = reader.GetString(4);
                bunifuTextBox5.Text = reader.GetString(5);
                bunifuTextBox6.Text = reader.GetString(6);
                bunifuTextBox7.Text = reader.GetString(7);
                bunifuTextBox8.Text = reader.GetValue(12).ToString();
                bunifuTextBox9.Text = reader.GetValue(13).ToString();
                bunifuTextBox10.Text = reader.GetString(2);
                bunifuTextBox11.Text = reader.GetString(8);
                bunifuTextBox12.Text= reader.GetString(10);
                bunifuTextBox13.Text = reader.GetValue(3).ToString();
            }
            reader.Close();
            con.Close();
        }
        public void updateData()
        {
             con.Open();
             OleDbCommand cmd = con.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "update Patients set date_naiss='" + bunifuDatePicker1.Value.ToShortDateString() + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set prem_date='" + bunifuDatePicker2.Value.ToShortDateString() + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set sexe='" + bunifuTextBox3.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set nom_père='" + bunifuTextBox4.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set nom_mère='" + bunifuTextBox5.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set fonct_père='" + bunifuTextBox6.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set fonct_mère='" + bunifuTextBox7.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set nb_enf_f='" + Convert.ToInt32(bunifuTextBox8.Text) + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set nb_enf_g='" + Convert.ToInt32(bunifuTextBox9.Text) + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set addresse='" + bunifuTextBox10.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set commune='" + bunifuTextBox11.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set wilaya='" + bunifuTextBox12.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             cmd.CommandText = "update Patients set tel='" + bunifuTextBox13.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
             cmd.ExecuteNonQuery();
             con.Close();
            MessageBox.Show(bunifuDatePicker1.Value.ToString("MM/dd/yyyy"));
            MessageBox.Show("Updated successfully");
        }
        public void Load_Patient()
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

        private void markBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }
    }
}
