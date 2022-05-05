using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace medical
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
            mainpanel.Dock = DockStyle.Fill;
        }
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
            
        }

        private void medicalbtn_Click(object sender, EventArgs e)
        {
            loadform(new viewmedical());
        }

        private void appointmentbtn_Click(object sender, EventArgs e)
        {
            loadform(new appointmentform());
        }

        private void statsbtn_Click(object sender, EventArgs e)
        {
            loadform(new stats());
        }
    }
}
