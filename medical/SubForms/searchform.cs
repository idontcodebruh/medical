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
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                finalGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetValue(14).ToString());
            }
            reader.Close();
            con.Close();
        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(bunifuTextBox1.Text))
                {
                    finalGrid.Rows.Clear();
                    con.Open();
                    OleDbCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Patients";
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        finalGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetValue(14).ToString());
                    }
                    reader.Close();
                    con.Close();

                    SearchNumberLabel.Text = finalGrid.Rows.Count.ToString() + " results";
                }
                else
                {
                    // DISPLAY IN DATAGRID STUFF
                    finalGrid.Rows.Clear();
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
                            cmd.CommandText = "select * from Patients where date_naiss ='" + strSearch + "'";
                            break;
                        default:
                            break;
                    }
                    OleDbDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        finalGrid.Rows.Add(reader.GetString(0), reader.GetString(1), reader.GetValue(14).ToString());
                    }
                    reader.Close();
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
                nom_child = finalGrid.SelectedRows[0].Cells[0].Value.ToString();
                prénom_child = finalGrid.SelectedRows[0].Cells[1].Value.ToString();
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


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void addbtn_Click(object sender, EventArgs e)
        {

        }

        private void finalGrid_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void finalGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
