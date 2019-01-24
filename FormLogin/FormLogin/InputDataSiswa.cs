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
    public partial class Formdt_siswa : Form
    {
        public Formdt_siswa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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

            MySqlCommand SelectCom = new MySqlCommand("insert into dt_siswa (nisn,nm_siswa,tmpt,tgl_lahir,jns_kel,no_tlp,agm,almt,nm_smpasl,nil_uan,no_sttbsmp,nil_sttbsmp,pict) values ('" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "','" + dateTimePicker1.Value + "','" + kel + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.comboBox1.SelectedItem + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "',load_file('"+textBox4.Text+"'));", connect);

            MySqlDataReader myRead;

            connect.Open();
            myRead = SelectCom.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();

            Formdt_siswa2 formdt_sw2 = new Formdt_siswa2();
            formdt_sw2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();
            fileChooser.Filter = "image files (*.jpg)|*.jpg|All files (*.*)|*.*";
            fileChooser.InitialDirectory = "D:Rumah";
            fileChooser.Title = "Select Image For Upload";
            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = fileChooser.FileName;
                textBox4.Text = fileChooser.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }
    }
}
