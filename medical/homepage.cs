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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\belha\\source\\repos\\medical\\medical\\Logs.accdb");
        private void homepage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appointmentDataSet1.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this.appointmentDataSet1.Table1);
            // TODO: This line of code loads data into the 'logsDataSet.Log' table. You can move, or remove it, as needed.
            this.logTableAdapter.Fill(this.logsDataSet.Log);
            refreshData();
            doCalc();

        }
        public void doCalc()
        {
            int appointmentCounter = 0;
            int processedCounter = 0;
            int canceledCounter = 0;
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime();
            date2 = DateTime.Now;
            dataGridView1.DataSource = table1BindingSource;
            /*
             * Update Appointments for today 
             *
             */
            for(int i =0; i < dataGridView1.RowCount; i++)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[i];
                date1 = Convert.ToDateTime(selectedRow.Cells[3].Value);
                if(DateTime.Compare(Convert.ToDateTime(date1.ToShortDateString()), Convert.ToDateTime(date2.ToShortDateString())) == 0)
                {
                    appointmentCounter++;
                    if (selectedRow.Cells[5].Value.ToString() == "Processed")
                    {
                        processedCounter++;
                    }
                    if (selectedRow.Cells[5].Value.ToString() == "Canceled")
                    {
                        canceledCounter++;
                    }
                }

            }
            appointmentsToday.Text = "Total : " + appointmentCounter;
            canceledAppointments.Text = "Total : " + canceledCounter;
            processedAppointments.Text = "Total : " + processedCounter;

        }

        public void refreshData()
        {

            /* REFRESH DATA */
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.CommandText = "select * from Log";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            OleDbDataAdapter dataAdapter1 = new OleDbDataAdapter(cmd);
            dataAdapter1.Fill(dt1);
            bunifuDataGridView1.DataSource = dt1;
            con.Close();
            /* REFRESH DATA */

        }
    }
}
