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
    public partial class Formkepalasekolah : Form
    {
        public Formkepalasekolah()
        {
            InitializeComponent();
        }

        private void Formkepalasekolah_Load(object sender, EventArgs e)
        {
            string connectionSQL = "server=localhost;database=akademik;userid=root;";

            try
            {
                MySqlConnection db = new MySqlConnection(connectionSQL);
                MySqlDataAdapter data = new MySqlDataAdapter();
                MySqlCommand cmd1 = db.CreateCommand();
                cmd1.CommandText = "select * from siswa;";
                data.SelectCommand = cmd1;
                DataSet dtset1 = new DataSet();
                data.Fill(dtset1, "hasil1");
                dataGridsw.DataSource = dtset1;
                dataGridsw.DataMember = "hasil1";

                MySqlCommand cmd2 = db.CreateCommand();
                cmd2.CommandText = "select * from guru;";
                data.SelectCommand = cmd2;
                DataSet dtset2 = new DataSet();
                data.Fill(dtset2, "hasil2");
                dataGridgr.DataSource = dtset2;
                dataGridgr.DataMember = "hasil2";

                MySqlCommand cmd3 = db.CreateCommand();
                cmd3.CommandText = "select * from staff;";
                data.SelectCommand = cmd3;
                DataSet dtset3 = new DataSet();
                data.Fill(dtset3, "hasil3");
                dataGridstf.DataSource = dtset3;
                dataGridstf.DataMember = "hasil3";

                MySqlCommand cmd4 = db.CreateCommand();
                cmd4.CommandText = "select * from mapel;";
                data.SelectCommand = cmd4;
                DataSet dtset4 = new DataSet();
                data.Fill(dtset4, "hasil4");
                dataGridmpl.DataSource = dtset4;
                dataGridmpl.DataMember = "hasil4";

                MySqlCommand cmd5 = db.CreateCommand();
                cmd5.CommandText = "select * from jadwal;";
                data.SelectCommand = cmd5;
                DataSet dtset5 = new DataSet();
                data.Fill(dtset5, "hasil5");
                dataGridjdl.DataSource = dtset5;
                dataGridjdl.DataMember = "hasil5";

                MySqlCommand cmd7 = db.CreateCommand();
                cmd7.CommandText = "select * from dt_mutasi;";
                data.SelectCommand = cmd7;
                DataSet dtset7 = new DataSet();
                data.Fill(dtset7, "hasil7");
                dataGridmts.DataSource = dtset7;
                dataGridmts.DataMember = "hasil7";

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
