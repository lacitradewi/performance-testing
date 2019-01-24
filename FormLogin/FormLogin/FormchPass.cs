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
    public partial class FormchPass : Form
    {
        public FormchPass()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form frmlg = new FrmLgin();
            frmlg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connect;
                string cs = @"server=localhost;userid=root;database=akademik";
                connect = new MySqlConnection(cs);

                MySqlCommand SelectCom = new MySqlCommand("select * from login where user_id = '" + this.textBox1.Text + "' and pass = '" + this.textBox2.Text + "';", connect);

                MySqlDataReader myRead;

                connect.Open();
                myRead = SelectCom.ExecuteReader();
                int count = 0;
                while (myRead.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    MySqlCommand SelectCom1 = new MySqlCommand("update login set pass = '" + this.textBox4.Text + "' where pass = '" + this.textBox2.Text + "';", connect);

                    MySqlDataReader myRead1;

                    myRead1 = SelectCom1.ExecuteReader();
                    MessageBox.Show("Data Saved");
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password are Incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
