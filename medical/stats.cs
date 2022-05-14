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
    public partial class stats : Form
    {
        public stats()
        {
            InitializeComponent();
        }
        /* GLOBAL VAR */
        public string global_nom = "";
        public string global_prénom = "";
        int toStop = 0;
        int[] minRange = new int[256];
        int[] maxRange = new int[256];
        string[] found = new string[200];
        int[] counter = new int[200];
        double[] personal_poids = new double[50];
        double[] personal_taille = new double[50];
        int pages = 0;
        int other_counter = 0;
        /* GLOBAL VAR */
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
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        void render(int index, int index2, int index3, bool skipCalc, bool test)
        {

            int n;
            bunifuChartCanvas1.XAxesGridLines = false;
            bunifuChartCanvas1.YAxesGridLines = false;
            bunifuPieChart1.TargetCanvas = bunifuChartCanvas1;
            bunifuLineChart1.TargetCanvas = bunifuChartCanvas2;
            bunifuBarChart1.TargetCanvas = bunifuChartCanvas3;
            bunifuRadarChart1.TargetCanvas = bunifuChartCanvas4;
            dataGridView1.DataSource = patientsBindingSource;
            dataGridView2.DataSource = examensBindingSource;
            dataGridView3.DataSource = anamneseBindingSource;
            bunifuChartCanvas1.Labels = new string[5];
            bunifuChartCanvas2.Labels = new string[5];
            bunifuChartCanvas3.Labels = new string[5];
            bunifuChartCanvas4.Labels = new string[5];
            if (bunifuChartCanvas1.Labels != null && bunifuChartCanvas2.Labels != null && bunifuChartCanvas3.Labels != null && bunifuChartCanvas4.Labels != null)
            {
                Array.Clear(bunifuChartCanvas1.Labels, 0, 5);
                Array.Clear(bunifuChartCanvas2.Labels, 0, 5);
                Array.Clear(bunifuChartCanvas3.Labels, 0, 5);
                Array.Clear(bunifuChartCanvas4.Labels, 0, 5);
            }
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
                bunifuChartCanvas4.Visible = false;


            }
            else if (index3 == 1)
            {
                bunifuChartCanvas2.Visible = true;
                bunifuChartCanvas1.Visible = false;
                bunifuChartCanvas3.Visible = false;
                bunifuChartCanvas4.Visible = false;
            }
            else if(index3 == 3)
            {
                bunifuChartCanvas3.Visible = false;
                bunifuChartCanvas1.Visible = false;
                bunifuChartCanvas2.Visible = false;
                bunifuChartCanvas4.Visible = true;
            }
            else
            {
                bunifuChartCanvas3.Visible = true;
                bunifuChartCanvas1.Visible = false;
                bunifuChartCanvas2.Visible = false;
                bunifuChartCanvas4.Visible = false;
            }
            switch (index)
            {

                case 0: // RESPONSILBE FOR PATIENT
                    switch (index2)
                    {
                        case 0: // WILAYA
                            if (!skipCalc)
                            {
                                Clear();
                                search_db(found, counter, 10);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                                
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            Do_Render();
                            break;
                        case 1: // COMMUNE

                            break;
                        case 2: // SEXE
                            if (!skipCalc)
                            {
                                Clear();
                                search_db(found, counter, 9);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 3: // ENFANTS

                            break;
                        case 4: //DATE NAISSANCE

                            break;
                        default:

                            break;
                    }

                    break;
                case 1: // RESPONSIBLE FOR EXAMEN
                    switch (index2)
                    {

                    }
                    break;
                case 2: // RESPONSIBLE FOR ANAMNESE
                    switch (index2)
                    {
                        case 0: // ANAMNESE > Né
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(0);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 1: // ANAMNESE > Lieu
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(1);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            Do_Render();
                            break;
                        case 2: // ANAMNESE > ALLAIT
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(3);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            Do_Render();
                            break;
                        case 3: // ANAMNESE > TABAC
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(27);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 4: // ANAMNESE > VACCINE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(16);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 5: // ANAMNESE > HYGIENE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(28);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 6: // ANAMNESE > NAISSANCE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(29);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            Do_Render();
                            break;

                    }
                    break;
                case 3: // RESPONSIBLE FOR PATIENT FOLLOW
                    Load_Patient();
                    if(String.IsNullOrEmpty(global_nom) && String.IsNullOrEmpty(global_prénom))
                    {
                        MessageBox.Show("No patient was loaded.");
                        return;
                    }
                    switch (index2)
                    {
                        
                        case 0:
                            if (!skipCalc)
                            {
                                Clear();
                                search_examen(11);
                                whereStop();
                                calcRange();
                           
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            List<double> data = new List<double>();
                            n = 0;
                            for (int i = minRange[other_counter]; i < maxRange[other_counter]; i++)
                            {

                                bunifuChartCanvas1.Labels[n] = found[i];
                                bunifuChartCanvas2.Labels[n] = found[i];
                                bunifuChartCanvas3.Labels[n] = found[i];
                                bunifuChartCanvas4.Labels[n] = found[i];
                                data.Add(personal_poids[i]);
                                n++;
                            }
                            
                            bunifuPieChart1.Data = data;
                            bunifuLineChart1.Data = data;
                            bunifuBarChart1.Data = data;
                            bunifuRadarChart1.Data = data;
                            var r = new Random();
                            List<Color> bgColors = new List<Color>();
                            for (int i = 0; i < 5; i++)
                            {
                                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
                            }
                            bunifuPieChart1.BackgroundColor = bgColors;
                            bunifuBarChart1.BackgroundColor = bgColors;
                            break;
                        case 1:
                            if (!skipCalc)
                            {
                                Clear();
                                search_examen(9);
                                whereStop();
                                calcRange();
                             
                            }
                            if (other_counter < pages && skipCalc && test)
                            {
                                other_counter++;
                            }
                            if (other_counter >= 1 && skipCalc && !test)
                            {
                                other_counter--;
                            }
                            List<double> data3 = new List<double>();
                            n = 0;
                            for (int i = minRange[other_counter]; i < maxRange[other_counter]; i++)
                            {

                                bunifuChartCanvas1.Labels[n] = found[i];
                                bunifuChartCanvas2.Labels[n] = found[i];
                                bunifuChartCanvas3.Labels[n] = found[i];
                                bunifuChartCanvas4.Labels[n] = found[i];
                                data3.Add(personal_poids[i]);
                                n++;
                            }

                            bunifuPieChart1.Data = data3;
                            bunifuLineChart1.Data = data3;
                            bunifuBarChart1.Data = data3;
                            bunifuRadarChart1.Data = data3;
                            var r1 = new Random();
                            List<Color> bgColors1 = new List<Color>();
                            for (int i = 0; i < 5; i++)
                            {
                                bgColors1.Add(Color.FromArgb(r1.Next(256), r1.Next(256), r1.Next(256)));
                            }
                            bunifuPieChart1.BackgroundColor = bgColors1;
                            bunifuBarChart1.BackgroundColor = bgColors1;
                            break;
                        default:

                            break;

                    }
                    break;
                default:

                    break;


            }

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
        public void search_examen(int cell)
        {
            int j = 0;
            double test_weight;
            for(int i =0;i< dataGridView2.Rows.Count; i++)
            {
                DataGridViewRow selectedRow = dataGridView2.Rows[i];
                if(selectedRow.Cells[0].Value.ToString() == global_nom && selectedRow.Cells[1].Value.ToString()  == global_prénom)
                {
                    // getting correct patient
                    if(selectedRow.Cells[cell].Value != System.DBNull.Value)
                    {
                        // getting only correct weight
                        
                        found[j] = global_nom +" "+global_prénom +" "+selectedRow.Cells[4].Value.ToString();
                        test_weight = Convert.ToDouble(selectedRow.Cells[cell].Value);
                        if ((cell == 11) && (test_weight > 1000)) // cba to do separate func for checking weight just doing it here
                        {
                            // FIX WEIGHTS IN GRAMS TO KG
                            test_weight = test_weight/1000;
                        }
                        personal_poids[j] = test_weight;
                        j++;
                    }
                }
            }

        }
        private void stats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.mALADES4DataSet.Patients);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Anamnese' table. You can move, or remove it, as needed.
            this.anamneseTableAdapter.Fill(this.mALADES4DataSet.Anamnese);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Examens' table. You can move, or remove it, as needed.
            this.examensTableAdapter.Fill(this.mALADES4DataSet.Examens);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex, false, false);

        }
        /*
         * This function determines where the rendering should stop.
         * This is used only to navigate throughout the graph because we are limited to 10 elements at once.
         * Due to the database having a large difference of items this can be useful.
         * Arguments : Array of elements
         */
        public void whereStop()
        {
            toStop = 0;
            for (int i = 0; i < found.Length; i++)
            {
                if (!String.IsNullOrEmpty(found[i]))
                {
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
        public void Clear()
        {
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
        public void search_db(string[] found, int[] counter, int cell)
        {
            bool wasFound;
            int temp = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                wasFound = false;
                DataGridViewRow selectedRow = dataGridView1.Rows[i];

                if (temp == 0)
                { // ADDING FIRST ITEM 
                    found[0] = selectedRow.Cells[cell].Value.ToString();

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
                    if (!wasFound && (selectedRow.Cells[cell].Value != null))
                    { // I DIDNT FIND THE ITEM IN THE LIST
                        found[j] = selectedRow.Cells[cell].Value.ToString();
                        counter[j]++;
                    }

                }

                

            }

        }
        /* SEARCH ANAMNESE FUNCTION OVERVIEW:
         * Arguments : int cell. Cell to look into
         * Function : Searches throughout the anamnese database for different options and fill the arrays for rendering the graphs
         * TODO : Optimize the search and reduce loops.
         */
        public void search_anamnese(int cell)
        {

            if (cell == 0 || cell == 1 || cell == 3|| cell == 29) // all others are done here
            {
                bool wasFound;
                int temp = 0;
                for (int i = 0; i < dataGridView3.RowCount; i++)
                {
                    wasFound = false;
                    DataGridViewRow selectedRow = dataGridView3.Rows[i];

                    if (temp == 0)
                    { // ADDING FIRST ITEM 
                        found[0] = selectedRow.Cells[cell].Value.ToString();

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
                        if (!wasFound && (selectedRow.Cells[cell].Value != null))
                        { // I DIDNT FIND THE ITEM IN THE LIST
                            found[j] = selectedRow.Cells[cell].Value.ToString();
                            counter[j]++;
                        }

                    }



                }
            }
            else // doing tabac or hygiene or vaccination test
            {
                if(cell== 16) // RESPONSIBLE FOR CHECKING VACCINATION
                {
                        found[0] = "Vacciné";
                        found[1] = "Non-Vacciné";
                        found[2] = "01";
                        found[3] = "02";
                        found[4] = "03";
                        for (int i = 0; i < dataGridView3.Rows.Count; i++)
                        {
                            
                            DataGridViewRow selectedRow = dataGridView3.Rows[i];
                        string a = selectedRow.Cells[16].Value.ToString();
                        string b = selectedRow.Cells[17].Value.ToString();
                        string c = selectedRow.Cells[18].Value.ToString();
                        string d = selectedRow.Cells[19].Value.ToString();
                        string e = selectedRow.Cells[20].Value.ToString();
                        string f = selectedRow.Cells[21].Value.ToString();
                        string g = selectedRow.Cells[22].Value.ToString();
                        string h = selectedRow.Cells[23].Value.ToString();
                        string j = selectedRow.Cells[24].Value.ToString();
                        string k = selectedRow.Cells[25].Value.ToString();
                        string l = selectedRow.Cells[26].Value.ToString();
                        string[] array_vaccine = {a,b,c,d,e,f,g,h,j,k,l };
                            if (array_vaccine.Contains("True")) // Vaccinated?
                            {
                                counter[0] = counter[0] + 1;
                            }
                            else // Non-vaccinated?
                            {
                                counter[1] = counter[1] + 1;
                            }
                        }
                }
                if (cell==27) // RESPONSIBLE FOR CHECKING TABAC
                {
                    found[0] = "Fumeur";
                    found[1] = "Non-Fumeur";
                    found[2] = "01";
                    found[3] = "02";
                    found[4] = "03";
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        
                        DataGridViewRow selectedRow = dataGridView3.Rows[i];
                        if(selectedRow.Cells[cell].Value.ToString() == "True") // Smoker?
                        {
                            
                            counter[0]= counter[0]+1;
                        }
                        else // Non-smoker
                        {
                            counter[1]= counter[1]+1;
                        }
                    }
                }
                if (cell==28) // RESPONBILE FOR CHECKING HYGIENE
                {
                    found[0] = "Hygiène";
                    found[1] = "No hygiène";
                    found[2] = "01";
                    found[3] = "02";
                    found[4] = "03";
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        DataGridViewRow selectedRow = dataGridView3.Rows[i];
                        if (selectedRow.Cells[cell].Value.ToString() == "True") // Hygiene
                        {

                            counter[0] = counter[0] + 1;
                        }
                        else // No Hygiene
                        {
                            counter[1] = counter[1] + 1;
                        }
                    }
                }
            }
        }
        private void databaseDrop_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (databaseDrop.SelectedIndex == 0)
            {
                optionToRender.Items.Clear();
                optionToRender.Items.Add("Wilaya");
                optionToRender.Items.Add("Commune");
                optionToRender.Items.Add("Sexe");
                optionToRender.Items.Add("Enfants");
                optionToRender.Items.Add("Date naissance");
            }
            if (databaseDrop.SelectedIndex == 1)
            {
                optionToRender.Items.Clear();
            }
            if(databaseDrop.SelectedIndex == 2)
            {
                optionToRender.Items.Clear();
                optionToRender.Items.Add("Né");
                optionToRender.Items.Add("Lieu");
                optionToRender.Items.Add("Allait");
                optionToRender.Items.Add("Fumeur/Non fumeur");
                optionToRender.Items.Add("Vacciné/Non vacciné");
                optionToRender.Items.Add("Hygiene");
                optionToRender.Items.Add("Naissance");

            }
            if(databaseDrop.SelectedIndex == 3)
            {
                optionToRender.Items.Clear();
                optionToRender.Items.Add("Poids");
                optionToRender.Items.Add("Taille");
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
            int test;
            if ((int)(Math.Ceiling(estimate_page_main)) == 0)
            {
                pages = 1;
                test = 1;
            }
            else
            {

                test = (int)(Math.Ceiling(estimate_page_main));
                MessageBox.Show(test + " ");
            }
            for (int i = 0; i < test; i++)
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
                    flag = true;
                }
                else
                {
                    if (maxRange[i - 1] < toStop - 5)
                    {
                        minRange[i] = minRange[i - 1] + 5;
                        maxRange[i] = maxRange[i - 1] + 5;
                    }
                    else if (maxRange[i - 1] < toStop)
                    {
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
            render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex, true, true);
        }

        private void nav_left_Click(object sender, EventArgs e)
        {
            /* TODO: calculate minRange
             * 
             */
            render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex, true, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        public void Do_Render() // HANDLE RENDERING PROCESS
        {
            int n;
            //TODO : HANDLE GRAPH CHANGE AT ANYTIME     
            List<double> data = new List<double>();
            n = 0;
            for (int i = minRange[other_counter]; i < maxRange[other_counter]; i++)
            {

                bunifuChartCanvas1.Labels[n] = found[i];
                bunifuChartCanvas2.Labels[n] = found[i];
                bunifuChartCanvas3.Labels[n] = found[i];
                bunifuChartCanvas4.Labels[n] = found[i];
                data.Add(counter[i]);
                n++;
            }
            n = 0;
            bunifuPieChart1.Data = data;
            bunifuLineChart1.Data = data;
            bunifuBarChart1.Data = data;
            bunifuRadarChart1.Data = data;
            var r = new Random();
            List<Color> bgColors = new List<Color>();
            for (int i = 0; i < 5; i++)
            {
                bgColors.Add(Color.FromArgb(r.Next(256), r.Next(256), r.Next(256)));
            }
            bunifuPieChart1.BackgroundColor = bgColors;
            bunifuBarChart1.BackgroundColor = bgColors;

        }
    }
}