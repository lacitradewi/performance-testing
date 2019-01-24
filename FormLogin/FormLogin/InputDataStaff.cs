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
    public partial class Formdt_staff : Form
    {
        public Formdt_staff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kel = "O";

            if (radioButton1.Checked == true)
            {
                kel = "L";
            }
            else if (radioButton2.Checked == true)
            {
                kel = "P";
            }

            MySqlConnection connect;
            string cs = @"server=localhost;userid=root;database=akademik";
            connect = new MySqlConnection(cs);

            MySqlCommand SelectCom = new MySqlCommand("insert into dt_staff (kd_staff,nip,nm_staff,tmp_staff,tgl_lahirstaff,jns_kelstaff,no_tlpstaff,alm_staff,agm_staff,sd_staff,smp_staff,sma_staff,pt_staff,prog_stdstaff,pos) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox12.Text + "','" + kel + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox4.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.comboBox1.SelectedItem + "','" + this.comboBox2.SelectedItem + "');", connect);

            MySqlDataReader myRead;

            connect.Open();
            myRead = SelectCom.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            fileChooser.InitialDirectory = "D:Rumah";
            fileChooser.Title = "Select Image For Upload";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = fileChooser.FileName;
                textBox5.Text = fileChooser.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
