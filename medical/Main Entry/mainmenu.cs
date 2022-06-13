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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
            mainpanel.Dock = DockStyle.Fill;
        }
        public string global_username;
        public int permission=0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "utulisateur.accdb"));
        public void loadform(object Form) {
           
            if (this.mainpanel.Controls.Count > 0)
            {
                this.mainpanel.Controls.RemoveAt(0);
            }
                Form f = Form as Form;
                f.TopLevel = false;
                f.Dock = DockStyle.Fill;
                this.mainpanel.Controls.Add(f);
                this.mainpanel.Tag = f;
                f.Show();

            
            
        }

        public void Load_Username()
        { /* LOAD USERNAME NAME INTO GLOBAL VARS */

            var lines = File.ReadLines("current_user.txt");
            foreach (var line in lines)
            {
                global_username = line;
            }
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from users where username='"+ global_username+"'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                permission = reader.GetInt32(3);
            }
            con.Close();
        }
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchbtn_Click_1(object sender, EventArgs e)
        {
            loadform(new searchform());
        }

        private void homepagebtn_Click(object sender, EventArgs e)
        {
            loadform(new homepage());
        }

        private void medicalbtn_Click(object sender, EventArgs e)
        {
            loadform(new medicalview());
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            loadform(new appointmentform());
        }

        private void statsbtn_Click(object sender, EventArgs e)
        {
            loadform(new stats());
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {

        }

        private void mainmenu_Load(object sender, EventArgs e)
        {
            
            Load_Username();
            currentuser.Text = global_username.ToUpper();
            if(permission==0)
            {
                statsbtn.Visible = false;
                medicalbtn.Visible = false;
                homepagebtn.Visible = false;
                searchbtn.Visible = false;
                toolsBtn.Visible = false;
                loadform(new appointmentform());
            }
            else
            {
                loadform(new homepage());
            }
        }

        private void toolsBtn_Click(object sender, EventArgs e)
        {
            loadform(new Tools());
        }
    }
}
