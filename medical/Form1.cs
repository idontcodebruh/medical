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
    public partial class Form1 : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\Logs.accdb");
        public Form1()
        {
            InitializeComponent();
            //TODO: Auto login with remember me
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (!(passwordtxt.Text == "admin" && usernametxt.Text == "admin"))
            {
                MessageBox.Show("Wrong Password/Username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                MessageBox.Show("Welcome back, Doctor.", "Auth", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DateTime dt = DateTime.Now;
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into Log (AccessTime,[User]) values ('" + dt.ToString() + "','" + usernametxt.Text + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                mainmenu f2 = new mainmenu();
                this.Hide();
                f2.ShowDialog();
                this.Close();

            }
        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
        }
    }
}
