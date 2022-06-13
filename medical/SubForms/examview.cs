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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "MALADES4.accdb"));
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "PARAMETRES.accdb"));
        public examview()
        {
            InitializeComponent();
        }
        public string global_nom;
        public string global_prénom;
        bool flag = false;
        private void examview_Load(object sender, EventArgs e)
        {
            Load_Patient();
            populateFields();
        }
        public void updateData()
        {
            /*
             * Updating an existing row.
             */
            if (!flag)
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update Examens set objet='" + richTextBox1.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() +"'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set diagnostic='" + richTextBox4.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set Analyses='" + richTextBox5.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set maladie='" + richTextBox3.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set taille='" + Convert.ToDecimal(textBox1.Text) + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set poids='" + Convert.ToDecimal(textBox2.Text) + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "update Examens set P_C='" + Convert.ToDecimal(textBox3.Text) + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "' AND date_courante ='" + Convert.ToDateTime(Convert.ToString(bunifuDropdown1.SelectedItem)).ToShortDateString() + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("success");
                con.Close();
            }
            /*
             * Updating/Adding a new exam. 
             */
            else
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Examens (nom,prénom,matricule,date_naiss,date_courante,age,objet,diagnostic,Analyses,taille,P_C,poids,maladie) values('" + global_nom + "','" + global_prénom + "','" + String.Empty + "','" + bunifuDatePicker1.Value.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "','" + Convert.ToInt32("0") + "','" + richTextBox1.Text + "','" + richTextBox4.Text + "','" + richTextBox5.Text + "','" + Convert.ToDecimal(textBox1.Text)+ "','" + Convert.ToDecimal(textBox2.Text) + "','" + Convert.ToDecimal(textBox3.Text) + "','" + richTextBox3.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully added the new exam.");
                con.Close();
                flag = false;
            }

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
                MessageBox.Show(reader.GetValue(3).ToString());
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
            /*
             * Populate all type of objet de contrôle
             */
            con1.Open();
            cmd1.CommandText = "select * from objet_contrôle";
            reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                bunifuDropdown6.Items.Add(reader1.GetString(0));
            }
            con1.Close();
        }
        
        private void markBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }

        // #### HANDLE CHANGES ON DROP DOWN #### //
        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "' AND date_courante='" + Convert.ToDateTime(bunifuDropdown1.SelectedItem).ToShortDateString() + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show(textBox1.Text);
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
        // #### HANDLE CHANGES ON DROP DOWN #### //
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(richTextBox3.Text))
            {
                richTextBox3.AppendText("->Maladie: " + Convert.ToString(bunifuDropdown2.SelectedItem));
                richTextBox3.AppendText("\n");
                richTextBox3.AppendText("->Symptomes: " + Convert.ToString(bunifuDropdown3.SelectedItem));
            }
            else
            {
                richTextBox3.AppendText("\n");
                richTextBox3.AppendText("->Maladie: " + Convert.ToString(bunifuDropdown2.SelectedItem));
                richTextBox3.AppendText("\n");
                richTextBox3.AppendText("->Symptomes: " + Convert.ToString(bunifuDropdown3.SelectedItem));
            }
            richTextBox4.AppendText(richTextBox2.Text);

            if (String.IsNullOrEmpty(richTextBox5.Text))
            {
                richTextBox5.AppendText("->Type: " + Convert.ToString(bunifuDropdown4.SelectedItem));
                richTextBox5.AppendText("\n");
                richTextBox5.AppendText("->Detail: " + Convert.ToString(bunifuDropdown5.SelectedItem));
            }
            else
            {
                richTextBox5.AppendText("\n");
                richTextBox5.AppendText("->Type: " + Convert.ToString(bunifuDropdown4.SelectedItem));
                richTextBox5.AppendText("\n");
                richTextBox5.AppendText("->Detail: " + Convert.ToString(bunifuDropdown5.SelectedItem));
            }
            if (String.IsNullOrEmpty(richTextBox1.Text))
            {
                
                richTextBox1.AppendText(Convert.ToString(bunifuDropdown6.SelectedItem));
            }
            else
            {
                richTextBox1.AppendText(",");
                richTextBox1.AppendText(Convert.ToString(bunifuDropdown6.SelectedItem));
            }

        }
        /*
         * Clears all fields for a new exam and add a new date to the list.
         */
        private void newexamBtn_Click(object sender, EventArgs e)
        {
            flag = true;
            bunifuDropdown1.Items.Add(DateTime.Today.ToShortDateString());
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            richTextBox1.Text = String.Empty;
            richTextBox2.Text = String.Empty;
            richTextBox3.Text = String.Empty;
            richTextBox4.Text = String.Empty;
            richTextBox5.Text = String.Empty;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "' AND date_courante='" + bunifuDropdown1.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("deleted record succesfully");
            con.Close();
        }
    }
}
