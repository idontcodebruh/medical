using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace medical
{
    public partial class searchform : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        public searchform()
        {
            InitializeComponent();
            File.WriteAllText("current_patient.txt", "");
        }

        private void searchform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mALADES4DataSet.Examens' table. You can move, or remove it, as needed.
            this.examensTableAdapter.Fill(this.mALADES4DataSet.Examens);
            // TODO: This line of code loads data into the 'mALADES4DataSet.Patients' table. You can move, or remove it, as needed.
            this.patientsTableAdapter.Fill(this.mALADES4DataSet.Patients);
            
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nom_child;
            string prénom_child;
            string matricule;
            string date_naissance;
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(bunifuTextBox1.Text))
                {
                    finalGrid.Rows.Clear();
                    dataGridView1.DataSource = patientsBindingSource;
                    int row_count = dataGridView1.Rows.Count;

                    for(int i = 0; i < row_count; i++)
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[i];
                        nom_child = selectedRow.Cells[0].Value.ToString();
                        prénom_child = selectedRow.Cells[1].Value.ToString();
                        matricule = selectedRow.Cells[11].Value.ToString();
                        date_naissance = selectedRow.Cells[14].Value.ToString();
                        finalGrid.Rows.Add(matricule,nom_child,prénom_child,date_naissance);

                    }
                    SearchNumberLabel.Text = finalGrid.Rows.Count.ToString() + " results";
                }
                else
                {
                    // DISPLAY IN DATAGRID STUFF
                    string strSearch = bunifuTextBox1.Text;
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    switch (bunifuDropdown1.SelectedIndex)
                    {
                        case 0: // NOM
                            cmd.CommandText = "select * from Patients where nom LIKE '%" + strSearch + "%'";
                            break;
                        case 1: // PRENOM
                            cmd.CommandText = "select * from Patients where prénom LIKE '%" + strSearch + "%'";
                            break;
                        case 2: // MATRICULE
                            cmd.CommandText = "select * from Patients where matricule ='" + strSearch + "'";
                            break;
                        case 3: // DATE NAISSANCE
                            cmd.CommandText = "select * from Patients where date_naiss ='" + strSearch + "'";
                            break;
                        default:
                            break;
                    }
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                    dataAdapter.Fill(dt);
                    dataGridView1.DataSource=dt;
                    finalGrid.Rows.Clear();
                    for (int i = 0; i < dataGridView1.RowCount; i++)
                    {
                        DataGridViewRow selectedRow = dataGridView1.Rows[i];
                        nom_child = selectedRow.Cells[0].Value.ToString();
                        prénom_child = selectedRow.Cells[1].Value.ToString();
                        matricule = selectedRow.Cells[11].Value.ToString();
                        date_naissance = selectedRow.Cells[14].Value.ToString();
                        finalGrid.Rows.Add(matricule, nom_child, prénom_child, date_naissance);

                    }
                    SearchNumberLabel.Text = finalGrid.Rows.Count.ToString() + " results";
                    con.Close();
                }
            }
        }
        private void viewuser_Click(object sender, EventArgs e)
        {
            int current_row = finalGrid.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (current_row > 0)
            {
                string nom_child;
                string prénom_child;
                nom_child = finalGrid.SelectedRows[0].Cells[1].Value.ToString();
                prénom_child = finalGrid.SelectedRows[0].Cells[2].Value.ToString();
                MessageBox.Show("Loaded Patient, now goto Medical File Viewer.");
                StringBuilder full_value = new StringBuilder();
                full_value.Append(nom_child);
                full_value.Append("\n");
                full_value.Append(prénom_child);
                File.WriteAllText("current_patient.txt", full_value.ToString());

            }

        }

        private void edituser_Click(object sender, EventArgs e)
        {

        }

        private void deleteuser_Click(object sender, EventArgs e)
        {

        }
        private void test_func() { 
        
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addform f = new addform();
            f.ShowDialog();
            this.Close();
        }

        private void finalGrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void finalGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
