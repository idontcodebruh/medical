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
    public partial class medicalview : Form
    {
        public medicalview()
        {
            InitializeComponent();
            viewpanel.Dock = DockStyle.Fill;
        }
        public string global_nom;
        public string global_prénom;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source="+ Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"MALADES4.accdb"));
        public void loadform(object Form)
        {

            if (this.viewpanel.Controls.Count > 0)
            {
                this.viewpanel.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.viewpanel.Controls.Add(f);
            this.viewpanel.Tag = f;
            f.Show();
        }

        private void patientbtn_Click(object sender, EventArgs e)
        {
            loadform(new patientinfo());

        }

        private void anamnesebtn_Click(object sender, EventArgs e)
        {
            loadform(new anamneseinfo());
        }

        private void exambtn_Click(object sender, EventArgs e)
        {
            loadform(new examview());
        }

        private void graphbtn_Click(object sender, EventArgs e)
        {
            loadform(new patientgraph());
        }

        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(bunifuTextBox1.Text)) {
                if (bunifuDropdown1.SelectedIndex == 0) // NOM SEARCH
                {
                    bunifuDataGridView1.Rows.Clear();
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Patients where nom LIKE '%" + bunifuTextBox1.Text + "'";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bunifuDataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                    reader.Close();
                    con.Close();
                }
                if (bunifuDropdown1.SelectedIndex == 1) // prénom SEARCH
                {
                    bunifuDataGridView1.Rows.Clear();
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Patients where prénom LIKE '%" + bunifuTextBox1.Text + "'";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        bunifuDataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1));
                    }
                    reader.Close();
                    con.Close();
                }
            }
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Patients";
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    bunifuDataGridView1.Rows.Add(reader.GetString(0), reader.GetString(1));
                }
                reader.Close();
                con.Close();
            }
            if(bunifuDataGridView1.Rows.Count == 0)
            {
                bunifuToggleSwitch1.Checked = false;
                bunifuToggleSwitch2.Checked = false;
                bunifuToggleSwitch3.Checked = false;
            }
        }

        private void viewpanel_Paint(object sender, PaintEventArgs e)
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
        private void medicalview_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDataGridView1.Rows.Add(reader.GetString(0),reader.GetString(1)); 
            }
            reader.Close();
            con.Close();
            Load_Patient();
            nomLabel.Text = global_nom;
            prénomLabel.Text = global_prénom;
            // LOAD INTO GENERAL INFO 
            if (!String.IsNullOrEmpty(nomLabel.Text) && !String.IsNullOrEmpty(prénomLabel.Text)) { // ESSENTIAL CHECK
                string nom_child;
                string prénom_child;
                nom_child = nomLabel.Text;
                prénom_child = prénomLabel.Text;
                con.Open();
                cmd.CommandText = "select * from Examens where nom ='" + nom_child + "' AND prénom='" + prénom_child + "'";
                var test = cmd.ExecuteNonQuery();
                if (test == 0) // NO RESULT
                {
                    bunifuToggleSwitch3.Checked = false;
                }
                else
                {
                    bunifuToggleSwitch3.Checked = true;
                }
                cmd.CommandText = "select * from Anamnese where nom ='" + nom_child + "' AND prénom='" + prénom_child + "'";
                test = cmd.ExecuteNonQuery();
                if (test == 0)
                {
                    bunifuToggleSwitch2.Checked = false;
                }
                else
                {
                    bunifuToggleSwitch2.Checked = true;
                }
                cmd.CommandText = "select * from Patients where nom='" + nom_child + "' AND prénom ='" + prénom_child + "'";
                test = cmd.ExecuteNonQuery();
                if(test == 0)
                {
                    bunifuToggleSwitch1.Checked = false;
                }
                else
                {
                    bunifuToggleSwitch1.Checked = true;
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int current_row = bunifuDataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                string nom_child;
                string prénom_child;
                nom_child = bunifuDataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                prénom_child = bunifuDataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                MessageBox.Show("Loaded Patient, now goto Medical File Viewer.");
                StringBuilder full_value = new StringBuilder();
                full_value.Append(nom_child);
                full_value.Append("\n");
                full_value.Append(prénom_child);
                File.WriteAllText("current_patient.txt", full_value.ToString());
                bunifuToggleSwitch1.Checked = true;
                nomLabel.Text = nom_child;
                prénomLabel.Text = prénom_child;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Examens where nom ='" + nom_child + "' AND prénom='" + prénom_child + "'";
                var test = cmd.ExecuteNonQuery();
                 if(test == 0) // NO RESULT
                {
                    bunifuToggleSwitch3.Checked = false;
                }
                else
                {
                    bunifuToggleSwitch3.Checked = true;
                }
                cmd.CommandText = "select * from Anamnese where nom ='" + nom_child + "' AND prénom='" + prénom_child + "'";
                test = cmd.ExecuteNonQuery();
                if(test == 0)
                {
                    bunifuToggleSwitch2.Checked = false;
                }
                else
                {
                    bunifuToggleSwitch2.Checked = true;
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void traitmentbtn_Click(object sender, EventArgs e)
        {
            loadform(new traitmentinfo());
        }
    }
}
