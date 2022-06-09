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
        string[] found = new string[3000];
        int[] counter = new int[3000];
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
        public string date_naissance(string date)
        {
            int found = 0;
            int pos=0;
            for(int i = 0; i<date.Length; i++)
            {
               if(date[i] == '/')
                {
                    found++;
                }
                if (found == 2)
                {
                    pos = i + 1;
                    break;
                }
            }
            
            string remaining = date.Substring(pos, 4);
            return remaining;
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "MALADES4.accdb"));
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
                                fixFound();
                                
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
                            if (!skipCalc)
                            {
                                Clear();
                                search_db(found, counter, 8);
                                whereStop(); // FIND WHERE SHOULD WE STOP
                                calcRange();
                                fixFound();
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
                        case 2: // SEXE
                            if (!skipCalc)
                            {
                                Clear();
                                search_db(found, counter, 9);
                                whereStop();
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 3: // ENFANTS

                            break;
                        case 4: //DATE NAISSANCE
                             if (!skipCalc)
                             {
                                 Clear();
                                 search_dates(14);
                                 whereStop();
                                 calcRange();
                                 fixFound();
                            }
                             Do_Render();
                                
                            break;
                        default:

                            break;
                    }

                    break;
                case 1: // RESPONSIBLE FOR EXAMEN
                    switch (index2)
                    {
                        case 0:

                            break;
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
                                whereStop(); 
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 1: // ANAMNESE > Lieu
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(1);
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
                            Do_Render();
                            break;
                        case 2: // ANAMNESE > ALLAIT
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(3);
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
                            Do_Render();
                            break;
                        case 3: // ANAMNESE > TABAC
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(27);
                                whereStop();
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 4: // ANAMNESE > VACCINE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(16);
                                whereStop(); 
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 5: // ANAMNESE > HYGIENE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(28);
                                whereStop();
                                calcRange();
                            }
                            Do_Render();
                            break;
                        case 6: // ANAMNESE > NAISSANCE
                            if (!skipCalc)
                            {
                                Clear();
                                search_anamnese(29);
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
                            Do_Render();
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

        private void stats_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.mALADES4DataSet.Patients);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Anamnese' table. You can move, or remove it, as needed.
            this.anamneseTableAdapter.Fill(this.mALADES4DataSet.Anamnese);
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
        public void search_dates(int cell)
        {
            bool wasFound;
            int temp = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                wasFound = false;
                DataGridViewRow selectedRow = dataGridView1.Rows[i];

                if (temp == 0)
                { // ADDING FIRST ITEM 
                    found[0] = date_naissance(selectedRow.Cells[cell].Value.ToString());
                    counter[0]++;
                    temp++;
                }
                else
                {
                    int j = 0;
                    while (!String.IsNullOrEmpty(found[j]))
                    {
                        if (selectedRow.Cells[cell].Value == System.DBNull.Value)
                        {
                            // SKIP CUZ THIS IS NULL
                            break;
                        }
                        if (date_naissance(selectedRow.Cells[cell].Value.ToString()) == found[j])
                        { // CHECK IF ITEM ALRDY EXISTS IN MY ARRAY
                            wasFound = true;
                            counter[j]++;
                        }
                        j++;
                    }
                    if (!wasFound && (selectedRow.Cells[cell].Value != System.DBNull.Value))
                    { // I DIDNT FIND THE ITEM IN THE LIST
                        found[j] = date_naissance(selectedRow.Cells[cell].Value.ToString());
                        counter[j]++;
                    }

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
                        if (selectedRow.Cells[cell].Value.ToString().ToLower() == found[j].ToLower())
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
        /*
         * Fix missing items.
         * Idea behind : if last range was few items away from being a multiple of 5, we add the missing items.
         */
        public void fixFound()
        {
            MessageBox.Show("Pages :" + pages +
                            "\ntoStop :" + toStop +
                            "\nMissing items : " + getMissingItems());
            for(int i = 0; i < getMissingItems(); i++)
            {
                found[toStop + i] = found[toStop - 1];
                counter[toStop + i] = counter[toStop - 1];
                MessageBox.Show("added new item : " + found[toStop+i] + " Last item was : "+found[toStop-1]);
            }
        }
        public void fixOther()
        {
            MessageBox.Show("Pages :" + pages +
                "\ntoStop :" + toStop +
                "\nMissing items : " + getMissingItems());
            for (int i = 0; i < getMissingItems(); i++)
            {
                personal_poids[toStop + i] = personal_poids[toStop - 1];
                found[toStop + i] = found[toStop - 1];
                MessageBox.Show("added new item : " + personal_poids[toStop + i] + " Last item was : " + personal_poids[toStop - 1]);
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
                optionToRender.Items.Add("Maladie");
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
        }
        /*
         * CALCRANGE FUNCTION OVERVIEW
         * This function is used to calculate usable ranges for displaying in BUNIFU canvas.
         * It is also used to calculate max pages for navigation, since we are limited to 5 items per page
         */
        public void calcRange()
        {
            decimal estimate_page_main = (decimal)(toStop / 5);
            pages = (int)(Math.Ceiling((decimal)toStop / (decimal)5.0));
            int test;
            if ((int)(Math.Ceiling(estimate_page_main)) == 0)
            {
                pages = 1;
                test = 1;
            }
            else
            {
                pages = (int)(Math.Ceiling((double)toStop / 5.0));
                test = pages;
            }
            for (int i = 0; i < test; i++)
            {

                minRange[i] = (5*i);
                maxRange[i] = minRange[i] + 5;
        
            }

        }
        private void nav_right_Click(object sender, EventArgs e)
        {
            /* TODO: calculate new maxRange
             * 
             */
            render(databaseDrop.SelectedIndex, optionToRender.SelectedIndex, graphType.SelectedIndex, true, true);
        }
        /*
         * Returns missing items in order to fix rendering
         */
        public int getMissingItems()
        {
            return (minRange[pages - 1] + 5) - toStop;
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
            MessageBox.Show("minRange " + minRange[other_counter] + " maxRange " + maxRange[other_counter]);
            for (int i = minRange[other_counter]; i < maxRange[other_counter]; i++)
            {

                bunifuChartCanvas1.Labels[n] = found[i];
                bunifuChartCanvas2.Labels[n] = found[i];
                bunifuChartCanvas3.Labels[n] = found[i];
                bunifuChartCanvas4.Labels[n] = found[i];
                data.Add(counter[i]);
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

        }
    }
}