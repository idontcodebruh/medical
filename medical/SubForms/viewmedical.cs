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

    public partial class viewmedical : Form
    {
        public viewmedical()
        {
            InitializeComponent();
            
        }
        /* GLOBAL DEF*/
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        public string global_nom = "";
        public string global_prénom = "";
        public bool toggleMode = false;
        /* GLOBAL DEF*/
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        void Load_Patient() { /* LOAD PATIENT NAME INTO GLOBAL VARS */
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
        private void viewmedical_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Anamnese' table. You can move, or remove it, as needed.
            this.anamneseTableAdapter.Fill(this.mALADES4DataSet.Anamnese);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Examens' table. You can move, or remove it, as needed.
            this.examensTableAdapter.Fill(this.mALADES4DataSet.Examens);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.mALADES4DataSet.Patients);
            modestatus.Text = "Read";
            Load_Patient();
            patient_fullname.Text = global_nom + "-" + global_prénom;
            
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
       
            if (!String.IsNullOrEmpty(patient_fullname.Text) && !String.Equals(patient_fullname.Text,"-")) {
                // I KNOW IM NOT PERFORMING A VIEW ON AN EMPTY PATIENT NAME 
                con.Open();
                OleDbCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from Patients where nom ='" + global_nom + "'AND prénom='" + global_prénom + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
                con.Close();
                DataGridViewRow selectedRow = dataGridView1.Rows[0];
                addressetext.Text = selectedRow.Cells[2].Value.ToString();
                teltext.Text = selectedRow.Cells[3].Value.ToString();
                nom_pere_text.Text = selectedRow.Cells[4].Value.ToString();
                nom_mere_text.Text = selectedRow.Cells[5].Value.ToString();
                fonct_pere_text.Text = selectedRow.Cells[6].Value.ToString();
                fonct_mere_text.Text = selectedRow.Cells[7].Value.ToString();
                communetext.Text = selectedRow.Cells[8].Value.ToString();
                sexetext.Text = selectedRow.Cells[9].Value.ToString();
                wilayatext.Text = selectedRow.Cells[10].Value.ToString();
                matriculetext.Text = selectedRow.Cells[11].Value.ToString();
                f_text.Text = selectedRow.Cells[12].Value.ToString();
                m_text.Text = selectedRow.Cells[13].Value.ToString();
                date_text.Text = selectedRow.Cells[14].Value.ToString();
                prem_text.Text = selectedRow.Cells[15].Value.ToString();

                /* VIEW EXAM CALL */
                view_exam();
                /* VIEW EXAM CALL */
                /* VIEW ANAMNESE CALL*/
                view_anamese();
                /* VIEW ANAMNESE CALL*/
            }

        }

        private void examGroup_Enter(object sender, EventArgs e)
        {

        }

        private void togglebtn_Click(object sender, EventArgs e)
        {
            
            if (toggleMode) {
                modestatus.Text = "Read";
                return;
            }
            modestatus.Text = "Edit";
            toggleMode = !toggleMode;
        }
        public void view_exam() {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Examens where nom ='" + global_nom + "'AND prénom='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView2.DataSource = dt;
            con.Close();
            if (dataGridView2.RowCount == 0) {
                MessageBox.Show("Couldn't find exam for patient. Add a new Exam?", "Warning", MessageBoxButtons.YesNo);

                return;
            }
            DataGridViewRow selectedRow = dataGridView2.Rows[0];
            textBox16.Text = selectedRow.Cells[4].Value.ToString();
            textBox15.Text = selectedRow.Cells[5].Value.ToString();
            textBox14.Text = selectedRow.Cells[6].Value.ToString();
            textBox13.Text = selectedRow.Cells[7].Value.ToString();
            textBox12.Text = selectedRow.Cells[8].Value.ToString();
            textBox11.Text = selectedRow.Cells[9].Value.ToString();
            textBox10.Text = selectedRow.Cells[10].Value.ToString();
            textBox9.Text = selectedRow.Cells[11].Value.ToString();
            textBox8.Text = selectedRow.Cells[12].Value.ToString();
        }
        public void view_anamese() {

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Anamnese where nom ='" + global_nom + "'AND prénom='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(dt);
            dataGridView3.DataSource = dt;
            con.Close();
            if (dataGridView3.RowCount == 0)
            {
                MessageBox.Show("Couldn't find anamese for patient. Add a new anamnese?", "Warning", MessageBoxButtons.YesNo);

                return;
            }
            DataGridViewRow selectedRow = dataGridView3.Rows[0];
            textBox19.Text = selectedRow.Cells[0].Value.ToString();
            lieu.Text = selectedRow.Cells[1].Value.ToString();
            poids.Text = selectedRow.Cells[2].Value.ToString();
            allait.Text = selectedRow.Cells[3].Value.ToString();
            artif.Text = selectedRow.Cells[4].Value.ToString();
            duree.Text = selectedRow.Cells[5].Value.ToString();
            trait.Text = selectedRow.Cells[6].Value.ToString();
            ant_m.Text = selectedRow.Cells[7].Value.ToString();
            ant_c.Text = selectedRow.Cells[8].Value.ToString();
            ant_m_p.Text = selectedRow.Cells[9].Value.ToString();
            ant_c_p.Text = selectedRow.Cells[10].Value.ToString();
            Date.Text = selectedRow.Cells[15].Value.ToString();
            naissance.Text = selectedRow.Cells[29].Value.ToString();
            maternel.Text = selectedRow.Cells[30].Value.ToString();
            
        }



    }
    }

