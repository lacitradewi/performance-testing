using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using CrystalDecisions.CrystalReports.Engine;

namespace FormLogin
{
    public partial class Formsiswa : Form
    {

        

        public Formsiswa()
        {
            InitializeComponent();
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            mutasiTableAdapter1.Fill(dataSet11.Mutasi);
            dt_nilaiTableAdapter1.Fill(dataSet11.dt_nilai);
            dt_pljrTableAdapter1.Fill(dataSet11.dt_pljr);
            dt_sis_sklTableAdapter1.Fill(dataSet11.dt_sis_skl);       
        } 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public Label lblnis
        {
            get
            {
                return label14;
            }
        }

        private void Formsiswa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Mutasi' table. You can move, or remove it, as needed.
            DataTable dt = new DataTable();
            DataSet1 ds = new DataSet1();
            MySqlConnection connect;
            string cs = @"server=localhost;userid=root;database=akademik";
            connect = new MySqlConnection(cs);

            MySqlCommand sqlCmd = new MySqlCommand("select dt_siswa.nisn,nis,nm_siswa,kls from dt_siswa,dt_sis_skl where dt_siswa.nisn = dt_sis_skl.nisn and nis = '" + label14.Text + "';", connect);

            MySqlDataAdapter sqlDa = new MySqlDataAdapter(sqlCmd);

            MySqlDataReader myRead;

            connect.Open();
            myRead = sqlCmd.ExecuteReader();
            while (myRead.Read()) {
                if (myRead.HasRows) {
                    label9.Text = dt.Rows[0]["dt_siswa.nisn"].ToString();
                    label15.Text = dt.Rows[0]["nm_siswa"].ToString();
                    label16.Text = dt.Rows[0]["kls"].ToString();
                }
            }

            try
            {
                MySqlConnection db = new MySqlConnection(cs);
                MySqlDataAdapter data = new MySqlDataAdapter();
                MySqlCommand cmd5 = db.CreateCommand();
                cmd5.CommandText = "select * from jadwal;";
                data.SelectCommand = cmd5;
                DataSet dtset5 = new DataSet();
                data.Fill(dtset5, "hasil5");
                dataGridjdl.DataSource = dtset5;
                dataGridjdl.DataMember = "hasil5";

                MySqlCommand cmd6 = db.CreateCommand();
                cmd6.CommandText = "select * from nilai;";
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

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect;
            string cs = @"server=localhost;userid=root;database=akademik";
            connect = new MySqlConnection(cs);

            MySqlCommand SelectCom = new MySqlCommand("insert into dt_mutasi (nm_siswa,nisn,nis,jns_kel,nm_ort,krj_ort,alamat,nm_skltjn,ket,kota) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox7.Text + "','" + this.textBox3.Text + "','" + this.textBox6.Text + "','" + this.textBox5.Text + "','" + this.textBox8.Text + "');", connect);

            MySqlDataReader myRead;

            connect.Open();
            myRead = SelectCom.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.MutasiTableAdapter mtasi = new DataSet1TableAdapters.MutasiTableAdapter();

            mtasi.FillByno_su(ds.Mutasi);

            ReportClass rpt = new CrystalReport1();
            rpt.SetDataSource(ds);

            Form f2 = new FormMut(rpt);
            f2.ShowDialog();

            Cursor = Cursors.Default;
        }

        private void dataSet1BindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void fillByno_suToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.mutasiTableAdapter1.FillByno_su(this.dataSet11.Mutasi);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int col = 0;
            //int row = dataGridnl.SelectedCells[0].RowIndex;
            //int id = (int)dataGridnl[col, row].Value;
            
            Cursor = Cursors.WaitCursor;

            DataSet1 ds = new DataSet1();
            DataSet1TableAdapters.dt_nilaiTableAdapter nil = new DataSet1TableAdapters.dt_nilaiTableAdapter();
            DataSet1TableAdapters.dt_sis_sklTableAdapter sis = new DataSet1TableAdapters.dt_sis_sklTableAdapter();
            DataSet1TableAdapters.dt_pljrTableAdapter pljrn = new DataSet1TableAdapters.dt_pljrTableAdapter();

            nil.FillBynis(ds.dt_nilai);
            sis.FillBynisn(ds.dt_sis_skl);
            pljrn.FillBykd_pljrn(ds.dt_pljr);

            ReportClass rpt = new CrystalReport2();
            rpt.SetDataSource(ds);

            Form f3 = new FormNil(rpt);
            f3.ShowDialog();

            Cursor = Cursors.Default;
        }
    }
}
