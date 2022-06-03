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
    public partial class examview : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\PARAMETRES.accdb");
        public examview()
        {
            InitializeComponent();
        }
        public string global_nom;
        public string global_prénom;
        private void examview_Load(object sender, EventArgs e)
        {
            Load_Patient();
            populateFields();
        }
        public void updateData()
        {

        }
        public void readData()
        {

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
        public void populateFields()
        {
            label3.Text = global_nom;
            label4.Text = global_prénom;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDropdown1.Items.Add(reader.GetString(4));
                bunifuDatePicker1.Value = Convert.ToDateTime(reader.GetValue(3).ToString());
            }
            reader.Close();
            con.Close();
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from diagnostiques";
            OleDbDataReader reader1 = cmd1.ExecuteReader();

            /*
             * Populate all type of maladies 
             */
                for(int i = 0; i < reader1.FieldCount; i++)
                {
                    bunifuDropdown2.Items.Add(reader1.GetName(i));
                }
            con1.Close();

            con1.Open();
            cmd1.CommandText = "select * from examens_compl";
            reader1 = cmd1.ExecuteReader();
            /*
             * Populate all type of analyses
             */
            for(int i =0;i< reader1.FieldCount; i++)
            {
                bunifuDropdown4.Items.Add(reader1.GetName(i));
            }
            con1.Close();
        }
        
        private void markBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }
        
        /*
         * on index change, interactive look. 
         */
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "' AND date_courante='" + Convert.ToDateTime(bunifuDropdown1.SelectedItem).ToShortDateString() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader.GetValue(9).ToString();
                textBox2.Text = reader.GetValue(10).ToString();
                textBox3.Text = reader.GetValue(11).ToString();
                string objects = reader.GetString(6);
                objects = objects.Replace(" _ ", String.Empty);
                objects = objects.Replace("+", ",");
                richTextBox1.Text = objects;
                richTextBox3.Text = reader.GetValue(12).ToString();
                richTextBox4.Text = reader.GetValue(7).ToString();
                richTextBox5.Text = reader.GetValue(8).ToString();
            }
            con.Close();
        }

        private void bunifuDropdown2_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown3.Items.Clear();
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from diagnostiques";
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                bunifuDropdown3.Items.Add(reader1[bunifuDropdown2.SelectedIndex].ToString());
            }
            con1.Close();
        }

        private void bunifuDropdown4_SelectedIndexChanged(object sender, EventArgs e)
        {
            bunifuDropdown5.Items.Clear();
            con1.Open();
            OleDbCommand cmd1 = con1.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from examens_compl";
            OleDbDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                bunifuDropdown5.Items.Add(reader1[bunifuDropdown4.SelectedIndex].ToString());
            }

            con1.Close();
        }
    }
}
