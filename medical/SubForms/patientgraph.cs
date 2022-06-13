using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data.OleDb;
using System.IO;
namespace medical
{
    public partial class patientgraph : Form
    {
        public string global_nom;
        public string global_prénom;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.Combine("", "MALADES4.accdb"));
        public patientgraph()
        {

            InitializeComponent();
            Load_Patient();
            nomLabel.Text = global_nom;
            prénomLabel.Text = global_prénom;
            if(String.IsNullOrEmpty(global_nom) && String.IsNullOrEmpty(global_prénom))
            {
                MessageBox.Show("No patient was loaded");
                this.Close();
            }
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {

                Title = "Patient Growth",
            });

        }

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
        private void iconButton1_Click(object sender, EventArgs e)
        {
            initPatient();
        }
        public void initNormalChild()
        {
        }
        public void initPatient()
        {
            cartesianChart1.Series.Clear();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            var list = new List<DateTime>();
            var list3 = new List<DateTime>();
            var list4 = new List<String>();
            var list2 = new List<double>(); // <- clean list
          
            while (reader.Read())  // SORT ALL DATES.
            {
                list.Add(Convert.ToDateTime(reader.GetValue(4)));
            }
            reader.Close();
            list.Sort((a, b) => a.CompareTo(b)); 
            con.Close();
            con.Open();
            foreach(var item in list)
            {
                cmd.CommandText = "select * from Examens where nom='" + global_nom + "' AND prénom='" + global_prénom + "' AND date_courante ='" + item.ToShortDateString() + "'";
                reader = cmd.ExecuteReader();
                while (reader.Read()) // GET VALUES FOR EACH DATE
                {
                    if(bunifuDropdown1.SelectedIndex == 0) // Responbile for poids
                    {
                        if (reader.GetValue(11) == System.DBNull.Value)
                        {
                            // Detect the missing weight date
                        }
                        else
                        {
                            list4.Add(item.ToShortDateString());
                            list2.Add(fixWeight(Convert.ToDouble(reader.GetValue(11)))); // Check then add the correct weight.
                        }
                    }
                 if(bunifuDropdown1.SelectedIndex == 1) // Responsible for taille
                    {

                        if (reader.GetValue(9) == System.DBNull.Value)
                        {
                            // Detect the missing taille
                        }
                        else
                        {
                            list4.Add(item.ToShortDateString());
                            list2.Add(Convert.ToDouble(reader.GetValue(9)));
                        }
                    }
                }
                reader.Close();
                }
            con.Close();
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Date",

                Labels = list4.ToArray()

            });
            SeriesCollection series = new SeriesCollection();
            series.Add(new LineSeries() { Title = "Patient", Values = new ChartValues<double>(list2) });

            cartesianChart1.Series = series;
        }
        public double fixWeight(double weight)
        {
            if(weight > 10000)
            {
                weight = weight / 1000;
            }
            return weight;
        }
    }
}
