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
    public partial class addform : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\MALADES4.accdb");
        public addform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * INSERT FUNCTION into PATIENTS
             * TODO : INSERT INTO EXAM
             */
            con.Open();
 
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Patients (nom,prénom,addresse,tel,nom_père,nom_mère,fonct_père,fonct_mère,commune,sexe,wilaya,matricule,nb_enf_f,nb_enf_g,date_naiss,prem_date) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "','" + Int32.Parse(textBox13.Text) + "','" + Int32.Parse(textBox14.Text) + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker1.Value.ToShortDateString() + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("yes");
            con.Close();
        }
    }
}
