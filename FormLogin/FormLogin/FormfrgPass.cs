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
    public partial class FormfrgPass : Form
    {
        public FormfrgPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmlg = new FrmLgin();
            frmlg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                MySqlConnection connect;
                string cs = @"server=localhost;userid=root;database=akademik";
                connect = new MySqlConnection(cs);

                MySqlCommand SelectCom = new MySqlCommand("select dt_siswa.nisn,nis,no_tlp from dt_siswa,dt_sis_skl where dt_siswa.nisn = dt_sis_skl.nisn and dt_siswa.nisn = '" + this.textBox5.Text + "' and nis = '" + this.textBox1.Text + "' and no_tlp = '" + this.textBox2.Text + "';", connect);

                MySqlDataReader myRead;

                connect.Open();
                myRead = SelectCom.ExecuteReader();
                int count = 0;
                while(myRead.Read()){
                    count += 1;
                }
                if(count==1){
                    this.textBox3.ReadOnly = false;
                    this.textBox4.ReadOnly = false;
                    this.button3.Enabled = false;
                    this.button1.Enabled = true;
                    connect.Close();
                }
                else{
                    MessageBox.Show("NISN or Username or No Telp are Incorrect");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection connect;
            string cs = @"server=localhost;userid=root;database=akademik";
            connect = new MySqlConnection(cs);

            MySqlCommand SelectCom1 = new MySqlCommand("update login set pass = '" + this.textBox4.Text + "';", connect);

            MySqlDataReader myRead1;

            connect.Open();
            myRead1 = SelectCom1.ExecuteReader();
            MessageBox.Show("Data Saved");
            connect.Close();
        }
    }
}
