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
using MySql.Data.MySqlClient;

namespace FormLogin
{
    public partial class Formguru : Form
    {
        public Formguru()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formdt_nilai formdt_nl = new Formdt_nilai();
            formdt_nl.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Formguru_Load(object sender, EventArgs e)
        {
            string connectionSQL = "server=localhost;database=akademik;userid=root;";

            try
            {
                MySqlConnection db = new MySqlConnection(connectionSQL);
                MySqlDataAdapter data = new MySqlDataAdapter();
                MySqlCommand cmd5 = db.CreateCommand();
                cmd5.CommandText = "select * from jadwal;";
                data.SelectCommand = cmd5;
                DataSet dtset5 = new DataSet();
                data.Fill(dtset5, "hasil5");
                dataGridjdl.DataSource = dtset5;
                dataGridjdl.DataMember = "hasil5";

                MySqlCommand cmd6 = db.CreateCommand();
                cmd6.CommandText = "select * from nilaigr;";
                data.SelectCommand = cmd6;
                DataSet dtset6 = new DataSet();
                data.Fill(dtset6, "hasil6");
                dataGridnl.DataSource = dtset6;
                dataGridnl.DataMember = "hasil6";

            }
            catch (Exception kesalahan)
            {
                MessageBox.Show("Problem: " + kesalahan);
            }
        }

        private void butOut_Click(object sender, EventArgs e)
        {
            FrmLgin formLog = new FrmLgin();
            formLog.Show();
            this.Close();
        }
    }
}
