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
    public partial class medicalview : Form
    {
        public medicalview()
        {
            InitializeComponent();
            viewpanel.Dock = DockStyle.Fill;
        }
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
    }
}
