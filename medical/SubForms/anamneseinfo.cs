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
    public partial class anamneseinfo : Form
    {
        public anamneseinfo()
        {
            InitializeComponent();
        }
        public string global_nom;
        public string global_prénom;
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        private void anamneseinfo_Load(object sender, EventArgs e)
        {
            Load_Patient();
            if (String.IsNullOrEmpty(global_nom) || String.IsNullOrEmpty(global_prénom))
            {
                MessageBox.Show("No patient was loaded.");
                this.Close();
            }
            readData();
        }
        public void readData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Patients where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bunifuTextBox1.Text = reader.GetString(0);
                bunifuTextBox2.Text = reader.GetString(1);
                if (checkValidDate(reader.GetValue(14).ToString()))
                {
                    bunifuDatePicker1.Value = Convert.ToDateTime(reader.GetValue(14).ToString());

                }
                else
                {
                    MessageBox.Show("Patient has no valid date nassaince!");
                }
                if (checkValidDate(reader.GetValue(15).ToString()))
                {
                    bunifuDatePicker2.Value = Convert.ToDateTime(reader.GetValue(15).ToString());

                }
                else
                {
                    MessageBox.Show("Patient has no prem date!");
                }
                bunifuTextBox3.Text = reader.GetString(9);
            }
            reader.Close();
            con.Close();
            con.Open();
            cmd.CommandText = "select * from Anamnese where nom='" + global_nom + "' AND prénom='" + global_prénom + "'";
            OleDbDataReader reader1 = cmd.ExecuteReader();
            while (reader1.Read())
            {
                bunifuTextBox4.Text = reader1.GetString(0);
                bunifuTextBox5.Text = reader1.GetString(1);
                bunifuTextBox6.Text = reader1.GetString(2);
                bunifuTextBox7.Text = reader1.GetString(3);
                bunifuTextBox8.Text = reader1.GetString(4);
                bunifuTextBox9.Text = reader1.GetString(5);
                bunifuTextBox10.Text = reader1.GetString(6);
                bunifuTextBox11.Text = reader1.GetString(29);
                bunifuTextBox12.Text = reader1.GetString(30);
                bunifuToggleSwitch1.Checked = reader1.GetBoolean(16);
                bunifuToggleSwitch2.Checked = reader1.GetBoolean(17);
                bunifuToggleSwitch3.Checked = reader1.GetBoolean(18);
                bunifuToggleSwitch4.Checked = reader1.GetBoolean(19);
                bunifuToggleSwitch5.Checked = reader1.GetBoolean(20);
                bunifuToggleSwitch6.Checked = reader1.GetBoolean(21);
                bunifuToggleSwitch7.Checked = reader1.GetBoolean(22);
                bunifuToggleSwitch8.Checked = reader1.GetBoolean(23);
                bunifuToggleSwitch9.Checked = reader1.GetBoolean(24);
                bunifuToggleSwitch10.Checked = reader1.GetBoolean(25);
                bunifuToggleSwitch11.Checked = reader1.GetBoolean(26);
                bunifuToggleSwitch12.Checked = reader1.GetBoolean(27);
                bunifuToggleSwitch13.Checked = reader1.GetBoolean(28);
            }
            reader1.Close();
            con.Close();
        }
        public void updateData()
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Patients set date_naiss='" + bunifuDatePicker1.Value.ToShortDateString() + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Patients set prem_date='" + bunifuDatePicker2.Value.ToShortDateString() + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Patients set sexe='" + bunifuTextBox3.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set BCG_P=" + bunifuToggleSwitch1.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTCOQ_3M=" + bunifuToggleSwitch2.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTCOQ_4M=" + bunifuToggleSwitch3.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTCOQ_5M=" + bunifuToggleSwitch4.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTCOQ_18M=" + bunifuToggleSwitch5.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTA_11A=" + bunifuToggleSwitch6.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTA_16A=" + bunifuToggleSwitch7.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set ROUGEOLE_9M=" + bunifuToggleSwitch8.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set DTC_P_R_6A=" + bunifuToggleSwitch9.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set VitamD_1M=" + bunifuToggleSwitch10.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set VitamD_6M=" + bunifuToggleSwitch11.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set TABAC=" + bunifuToggleSwitch12.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set PROPRETE=" + bunifuToggleSwitch13.Checked + " where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set né='" + bunifuTextBox4.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set lieu='" + bunifuTextBox5.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set allait='" + bunifuTextBox6.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set poids='" + bunifuTextBox7.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set all_artif='" + bunifuTextBox8.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set réa_durée='" + bunifuTextBox9.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set réa_trait='" + bunifuTextBox10.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set naissance='" + bunifuTextBox11.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update Anamnese set maternel_durée='" + bunifuTextBox12.Text + "' where nom='" + global_nom + "' AND prénom ='" + global_prénom + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated successfully");
            readData(); // <- Reloads updated data
        }
        public bool checkValidDate(string s)
        {
            if (String.IsNullOrEmpty(s))
            {
                return false;
            }
            return true;
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

        private void markBtn_Click(object sender, EventArgs e)
        {
            updateData();
        }

        private void newexamBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Anamnese (né, lieu, poids, allait, all_artif, [réa_durée], [réa_trait], e_ant_m, e_ant_c, p_ant_m, p_ant_c, nom, prénom, matricule, date_naiss, [date], BCG_P, DTCOQ_3M, DTCOQ_4M, DTCOQ_5M, DTCOQ_18M, DTA_11A, DTA_16A, ROUGEOLE_9M, DTC_P_R_6A, VitamD_1M, VitamD_6M, TABAC, PROPRETE, naissance, [maternel_durée]) values('" + bunifuTextBox4.Text + "','" + bunifuTextBox5.Text + "','" + bunifuTextBox6.Text + "','" + bunifuTextBox7.Text + "','" + bunifuTextBox8.Text + "','" + bunifuTextBox9.Text + "','" + bunifuTextBox10.Text  + "','" + String.Empty + "','" + String.Empty + "','" + String.Empty + "','" + String.Empty + "','" + bunifuTextBox1.Text + "','" + bunifuTextBox2.Text + "','" + String.Empty + "','" + bunifuDatePicker1.Value.ToShortDateString() + "','" + DateTime.Now.ToShortDateString() + "'," + bunifuToggleSwitch1.Checked + "," + bunifuToggleSwitch2.Checked + ","+ bunifuToggleSwitch3.Checked+ "," + bunifuToggleSwitch4.Checked + "," + bunifuToggleSwitch5.Checked + "," + bunifuToggleSwitch6.Checked+","+ bunifuToggleSwitch7.Checked+ ","+ bunifuToggleSwitch8.Checked+ "," + bunifuToggleSwitch9.Checked+","+ bunifuToggleSwitch10.Checked+ ","+ bunifuToggleSwitch11.Checked+ ","+ bunifuToggleSwitch12.Checked + "," + bunifuToggleSwitch13.Checked + ",'" + bunifuTextBox11.Text + "','" + bunifuTextBox12.Text+ "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Succesfully added new anamnese.");
            con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Anamnese where nom='"+ global_nom + "' AND prénom ='"+ global_prénom + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted record succesfully");
            con.Close();
        }
    }
}
