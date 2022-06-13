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
    public partial class Tools : Form
    {
        public Tools()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "utulisateur.accdb"));
        OleDbConnection con1 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "PARAMETRES.accdb"));
        public string global_username;
        private void Tools_Load(object sender, EventArgs e)
        {
            Load_Username();
            bunifuDataGridView1.Rows.Clear();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDataGridView1.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString()); ;
            }
            reader.Close();
            con.Close();

        }
        public void Load_Username()
        { /* LOAD USERNAME NAME INTO GLOBAL VARS */

            var lines = File.ReadLines("current_user.txt");
            foreach (var line in lines)
            {
                global_username = line;
            }
        }
        // OBJET
        private void button1_Click(object sender, EventArgs e)
        {
            con1.Open();
            OleDbCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into objet_contrôle (objet) values('" + bunifuTextBox1.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con1.Close();
        }
        // TRAITMENT
        private void button3_Click(object sender, EventArgs e)
        {
            con1.Open();
            OleDbCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into ordonnances (generique,prescription) values('" + bunifuTextBox6.Text +"','"+ bunifuTextBox6.Text+"')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con1.Close();
        }
        // NEW USER
        private void button2_Click(object sender, EventArgs e)
        {
            int permission = 0;
            if(radioButton1.Checked == true)
            {
                permission = 1;
            }
            else
            {
                permission = 0;
            }
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into users (username, [password], permission, mobile) values('" + textBox1.Text + "','" + textBox2.Text + "','" + permission + "','" + 0 + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Success");
            refreshData();
            
        }
        // UPDATE USER
        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE users SET [password] = '" + textBox6.Text + "' WHERE(username = '" + global_username + "')";
            MessageBox.Show("Success");
            cmd.ExecuteNonQuery();
            con.Close();
            refreshData();
        }
        // CERTIFICAT
        private void button4_Click(object sender, EventArgs e)
        {
            con1.Open();
            OleDbCommand cmd = con1.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into certificats (type,texte) values('" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Success");
            con1.Close();
        }
        public void refreshData()
        {
            bunifuDataGridView1.Rows.Clear();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuDataGridView1.Rows.Add(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString()); ;
            }
            reader.Close();
            con.Close();
        }
    }
}
