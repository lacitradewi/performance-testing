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

namespace FormLogin
{
    public partial class Formdt_matpel : Form
    {
        public Formdt_matpel()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                MySqlConnection connect;
                string cs = @"server=localhost;userid=root;database=akademik";
                connect = new MySqlConnection(cs);

                MySqlCommand SelectCom = new MySqlCommand("insert into dt_pljr (kd_pljrn,nm_pljrn,ket) values ('" + this.kdtxt.Text + "','" + this.nmtxt.Text + "','" + this.kettxt.Text + "');", connect);

                MySqlDataReader myRead;

                connect.Open();
                myRead = SelectCom.ExecuteReader();
                MessageBox.Show("Data Saved");
                connect.Close();
        }
    }
}
