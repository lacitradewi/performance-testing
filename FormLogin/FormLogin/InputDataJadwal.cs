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
    public partial class Formdt_jadwal : Form
    {
        public Formdt_jadwal()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect;
            string cs = @"server=localhost;userid=root;database=akademik";
            connect = new MySqlConnection(cs);

            MySqlCommand SelectCom = new MySqlCommand("insert into dt_jadwal (smt,hri,kls,jm_pljrn,kd_pljrn,kd_gr) values ('" + this.comboBox1.SelectedItem + "','" + this.comboBox2.SelectedItem + "','" + this.comboBox3.SelectedItem + "','" + this.comboBox4.SelectedItem + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "');", connect);

            MySqlDataReader myRead;

            connect.Open();
            myRead = SelectCom.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();
        }
    }
}
