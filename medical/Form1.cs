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
                if (bunifuCheckBox1.Checked == true && (File.ReadAllText("settings.txt") != "true"))
                {
                    //Run this once and only once for instant login
                    string chkbox = "true";
                    File.WriteAllText("settings.txt", chkbox);
                  
                    
                }
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
