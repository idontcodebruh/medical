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
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }

        void render(string db,string option,string graph_type) {
            if (db == "Patient") {



            }

        }
        void renderLine()
        {


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void stats_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void databaseDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (databaseDrop.SelectedIndex == 0) {
                optionToRender.Items.Add("Address");
                optionToRender.Items.Add("Commune");
                optionToRender.Items.Add("Sexe");
                optionToRender.Items.Add("Wilaya");
                optionToRender.Items.Add("Enfants");
                optionToRender.Items.Add("Date naissance");
            }
        }
    }
}
