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
namespace medical
{
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        void render(int index, int index2,int index3) {
            dataGridView1.DataSource = patientsBindingSource;
            switch (index) {
                case 0:
                    switch (index2)
                    {
                        case 0: // ADDRESSE
                            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas canvas = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.Canvas();
                            string[] found = new string[900];
                            int[] counter = new int[900];
                            int temp = 0;
                            bool wasFound;
                            
                            for (int i =0;i< dataGridView1.RowCount; i++)
                            {
                                wasFound = false;
                                
                                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                                if (temp == 0) { // ADDING FIRST ITEM 
                                    found[0] = selectedRow.Cells[10].Value.ToString();
                                    counter[0]++;
                                    temp++;
                                }
                                

                                else
                                {
                                    int j = 0;
                                    while (!String.IsNullOrEmpty(found[j]))
                                    {
                                        if (selectedRow.Cells[10].Value == null) {
                                            // SKIP CUZ THIS IS NULL
                                            break;
                                        }
                                        if (selectedRow.Cells[10].Value.ToString() == found[j]) { // CHECK IF ITEM ALRDY EXISTS IN MY ARRAY
                                            wasFound = true;
                                            counter[j]++;
                                        }
                                        j++;
                                    }
                                    if (!wasFound && (selectedRow.Cells[10].Value != null)) { // I DIDNT FIND THE ITEM IN THE LIST
                                        found[j] = selectedRow.Cells[10].Value.ToString();
                                        counter[j]++;
                                    }

                                }
                 


                            }
                            temp = 0;
                            Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint datapoint = new Bunifu.Dataviz.WinForms.BunifuDatavizBasic.DataPoint(Bunifu.Dataviz.WinForms.BunifuDatavizBasic._type.Bunifu_bar);
                            while (temp < 10)

                            {
                                datapoint.addLabely(found[temp], counter[temp].ToString());
                                MessageBox.Show(found[temp] + " Counnter :  " + counter[temp]);


                                temp++;
                                
                                
                                
                            }
                           
                            canvas.addData(datapoint);
                            bunifuDatavizBasic1.Render(canvas);
                            break;
                        case 1: // COMMUNE

                            break;
                        case 2: // SEXE

                            break;
                        case 3: // WILAYA

                            break;
                        case 4: //ENFANTS

                            break;
                        case 5: //DATE NAISSANCE

                            break;
                        default:

                            break;
                    }

                    break;
                case 1:
                    switch (index2) { 
                    
                    }
                    break;
                case 2:
                    switch (index2) { 
                    
                    
                    }
                    break;
                default:

                    break;
            
            
            }

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void stats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.mALADES4DataSet.Patients);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            render(databaseDrop.SelectedIndex,optionToRender.SelectedIndex,graphType.SelectedIndex);

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
            if (databaseDrop.SelectedIndex == 1) {
                optionToRender.Items.Clear();
            }
        }
    }
}
