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
    public partial class traitmentinfo : Form
    {
        public traitmentinfo()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MALADES4.accdb"));
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "PARAMETRES.accdb"));
        public string global_nom;
        public string global_prénom;
        private void traitmentinfo_Load(object sender, EventArgs e)
        {
            Load_Patient();
            if(String.IsNullOrEmpty(global_nom) || String.IsNullOrEmpty(global_prénom))
            {
                MessageBox.Show("No patient was loaded.");
                this.Close();
            }
            populateFields();
        }




        public void populateFields()
        {
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ordonnances";
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                bunifuDropdown1.Items.Add(reader1[0].ToString());
            }
            reader1.Close();
            con1.Close();
            bunifuTextBox1.Text = global_nom;
            bunifuTextBox2.Text = global_prénom;

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDatePicker1.Value = Convert.ToDateTime(reader.GetValue(14).ToString());
            }
            reader.Close();
            con.Close();

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

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = bunifuDropdown1.SelectedItem.ToString();
            richTextBox2.Text = richTextBox3.Text;
        }

        private void markBtn_Click(object sender, EventArgs e)
        {

        }

        private void newexamBtn_Click(object sender, EventArgs e)
        {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Traitements (nom, prénom, matricule, ordonnances, date_naiss, poids, certificats, lettres, bilans, [date]) values('" + bunifuTextBox1.Text + "','" + bunifuTextBox2.Text + "','" + String.Empty + "','" + richTextBox1.Text + "','" + bunifuDatePicker1.Value.ToShortDateString()  + "','" + 0 +  "','" + String.Empty  +  "','" + String.Empty + "','" + String.Empty + "','" + bunifuDatePicker2.Value.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record added succesfully");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Traitements where nom ='" + bunifuTextBox1.Text + "' AND prénom = '" + bunifuTextBox2.Text + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record deleted succesfully.");
            con.Close();
        }
    }
}
