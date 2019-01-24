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
    public partial class Formdt_siswa2 : Form
    {
        public Formdt_siswa2()
        {
            InitializeComponent();
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

            MySqlCommand SelectCom = new MySqlCommand("insert into dt_siswa (nm_ayah,krj_ayah,agm_ayah,no_tlp_ayah,almt_ayah,nm_ibu,krj_ibu,agm_ibu,no_tlp_ibu,almt_ibu,nm_wali,krj_wali,agm_wali,no_tlp_wali,almt_wali) values ('" + this.textBox1.Text + "','" + this.comboBox1.SelectedItem + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.comboBox2.SelectedItem + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox6.Text + "','" + this.textBox9.Text + "','" + this.comboBox3.SelectedItem + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "');", connect);

            MySqlDataReader myRead;

            connect.Open();
            myRead = SelectCom.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();
        }
    }
}
