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
        int toStop = 0;
        int[] minRange = new int[256];
        int[] maxRange = new int[256];
        string[] found = new string[900];
        int[] counter = new int[900];
        int pages = 0;
        bool cbn = false;
        int other_counter = 0;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        void render(int index, int index2,int index3,bool skipCalc) {
            dataGridView1.DataSource = patientsBindingSource;
            /*
             * This is used solely to know which graph type is being used.
             * Instead of having to add another switch we use a "var" to store the current graph type
             * 0 FOR PIE
             * 1 FOR BAR
             * 2 FOR LINE
             * Default for Pie
            */
            if (index3 == 0)
            {
                bunifuChartCanvas2.Visible = false;
                bunifuChartCanvas3.Visible = false;
                bunifuChartCanvas1.Visible = true;


            }
            else if (index3==1)
            {
                bunifuChartCanvas2.Visible = true;
                bunifuChartCanvas1.Visible = false;
                bunifuChartCanvas3.Visible = false;
            }
            else {
                bunifuChartCanvas3.Visible = true;
                bunifuChartCanvas1.Visible = false;
                bunifuChartCanvas2.Visible = false;
            }
            switch (index) {
                case 0:
                    switch (index2)
                    {
                        case 0: // WILAYA
                            


                            if (!skipCalc)
                            {
                                search_db(found, counter, 10);
                                whereStop(found); // FIND WHERE SHOULD WE STOP
                                if (!cbn) { calcRange(); }
                                
                            }
                            
                            //TODO : HANDLE GRAPH CHANGE AT ANYTIME
                           
                            
                            
                            List<double> data = new List<double>();
                            bunifuChartCanvas1.Labels = new string[5];
                            bunifuChartCanvas2.Labels = new string[5];
                            bunifuChartCanvas3.Labels = new string[5];
                            
                            Array.Clear(bunifuChartCanvas1.Labels, 0, 5);
                            Array.Clear(bunifuChartCanvas2.Labels, 0, 5);
                            Array.Clear(bunifuChartCanvas3.Labels, 0, 5);
                            for (int i = minRange[other_counter]; i < maxRange[other_counter]; i++) {
                               
                                bunifuChartCanvas1.Labels[i - (5*other_counter)] = found[i];
                                bunifuChartCanvas2.Labels[i - (5 * other_counter)] = found[i];
                                bunifuChartCanvas3.Labels[i - (5 * other_counter)] = found[i];
                                data.Add(counter[i]);
                                
                            }
                            /*if (other_counter < pages && skipCalc)
                            {
                                other_counter++;
                            }*/
                            bunifuChartCanvas1.XAxesGridLines = false; // only for pie?
                            bunifuChartCanvas1.YAxesGridLines = false;

                            bunifuPieChart1.Data = data;
                            bunifuLineChart1.Data = data;
                            bunifuBarChart1.Data = data;
                            bunifuPieChart1.TargetCanvas = bunifuChartCanvas1;
                            bunifuLineChart1.TargetCanvas = bunifuChartCanvas2;
                            bunifuBarChart1.TargetCanvas = bunifuChartCanvas3;
                            var r = new Random();
                            List<Color> bgColors = new List<Color>();
                            for (int i = 0; i < 5; i++)
                            {
                                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                            }
                            bunifuPieChart1.BackgroundColor = bgColors;
                            bunifuBarChart1.BackgroundColor = bgColors;
                            break;
                        case 1: // COMMUNE

                            break;
                        case 2: // SEXE

                            break;
                        case 3: // ENFANTS

                            break;
                        case 4: //DATE NAISSANCE

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

                render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex,false);

        }
        /*
         * This function determines where the rendering should stop.
         * This is used only to navigate throughout the graph because we are limited to 10 elements at once.
         * Due to the database having a large difference of items this can be useful.
         * Arguments : Array of elements
         */
        public void whereStop(string[] found)
        {
            toStop = 0;
            for (int i = 0; i < found.Length; i++) {
                if (!String.IsNullOrEmpty(found[i])) {
                    //CONTINUE
                    toStop++;
                }
                else
                {
                    break;
                }


            }

        }
        /*
         * We need to make sure we clear our toStop counter after each render. 
         * We also need to make sure we clear our arrays.
         */
        public void Clear(string[] found, int[] counter) {
            toStop = 0;
            pages = 0;
            other_counter = 0;
            Array.Clear(minRange, 0, minRange.Length);
            Array.Clear(maxRange, 0, maxRange.Length);
            Array.Clear(found, 0, found.Length);
            Array.Clear(counter, 0, counter.Length);
        }
        /*
         * Code clean up, now using this function to traverse the database
         * Arguments : string , int , int
         * Each arguments corresponds to : list of different strings in the DB, counter for each one , cell to look into
         * This would be called before trying to render graphs.
         *
         */
        public void search_db(string[] found,int[] counter,int cell) {
            bool wasFound;
            int temp = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                wasFound = false;

                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                if (temp == 0)
                { // ADDING FIRST ITEM 
                    found[0] = selectedRow.Cells[10].Value.ToString();
                    
                    counter[0]++;
                    temp++;
                }
                else
                {
                    int j = 0;
                    while (!String.IsNullOrEmpty(found[j]))
                    {
                        if (selectedRow.Cells[cell].Value == null)
                        {
                            // SKIP CUZ THIS IS NULL
                            break;
                        }
                        if (selectedRow.Cells[cell].Value.ToString() == found[j])
                        { // CHECK IF ITEM ALRDY EXISTS IN MY ARRAY
                            wasFound = true;
                            counter[j]++;
                        }
                        j++;
                    }
                    if (!wasFound && (selectedRow.Cells[10].Value != null))
                    { // I DIDNT FIND THE ITEM IN THE LIST
                        found[j] = selectedRow.Cells[cell].Value.ToString();
                       
                        counter[j]++;
                    }

                }



            }

        }
        private void databaseDrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (databaseDrop.SelectedIndex == 0) {
                optionToRender.Items.Add("Wilaya");
                optionToRender.Items.Add("Commune");
                optionToRender.Items.Add("Sexe");
                optionToRender.Items.Add("Enfants");
                optionToRender.Items.Add("Date naissance");
            }
            if (databaseDrop.SelectedIndex == 1) {
                optionToRender.Items.Clear();
            }
        }
        public void calcRange()
        {
            bool flag = false;
            decimal estimate_page_main = (decimal)(toStop / 10);
            decimal estimate_page_after = estimate_page_main - Math.Truncate(estimate_page_main);
            int page_nbr = (int)estimate_page_main;
            pages = (int)(Math.Ceiling(estimate_page_main));
            int other_nbr = (int)estimate_page_after;
            for(int i =0;i < (int)(Math.Ceiling(estimate_page_main)); i++)
            {
                // Regardless i am doing max pages required
                if (!flag)
                {
                    // Doing first iteration
                    minRange[0] = 0;
                    if (maxRange[0] < toStop - 5)
                    {
                        

                        maxRange[0] += 5;
                    }
                    else if (maxRange[0] < toStop)
                    {
                        
                        maxRange[0] += (toStop - maxRange[0]);
                    }
                    cbn = true;
                    flag = true;
                }
                else
                {
                    
                    if(maxRange[i-1] < toStop - 5)
                    {
                        minRange[i] = minRange[i - 1] + 5;
                        maxRange[i] = maxRange[i - 1] + 5;
                    }
                    else if(maxRange[i-1] < toStop) {
                        maxRange[i] = toStop - maxRange[i - 1];
                    }
                }

            }
        }
        private void nav_right_Click(object sender, EventArgs e)
        {
            /* TODO: calculate new maxRange
             * 
             */
            render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex, true);
        }

        private void nav_left_Click(object sender, EventArgs e)
        {
            /* TODO: calculate minRange
             * 
             */
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear(found,counter);
        }
    }
}
