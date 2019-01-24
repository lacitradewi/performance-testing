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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                MySqlConnection connect;
                string cs = @"server=localhost;userid=root;database=akademik";
                connect = new MySqlConnection(cs);

                MySqlCommand SelectCom = new MySqlCommand("select * from akademik.login where user_id='" + this.usertext.Text + "' and pass='" + this.passtext.Text + "';", connect);

                MySqlDataReader myRead;

                connect.Open();
                myRead = SelectCom.ExecuteReader();
                int count = 0;
                while(myRead.Read()){
                    count += 1;
                }
                if(count==1){
                    myRead.Close();
                    MySqlCommand Cmd = new MySqlCommand("select * from akademik.login where user_id='" + this.usertext.Text + "' and pass='" + this.passtext.Text + "' and left('" + this.usertext.Text + "',2)='01';", connect);

                    MySqlDataReader myRead2;

                    myRead2 = Cmd.ExecuteReader();
                    int count2 = 0;
                    while (myRead2.Read())
                    {
                        count2 += 1;
                    }
                    if (count2 == 1)
                    {
                        Formsiswa form2 = new Formsiswa();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        myRead2.Close();
                        MySqlCommand Cmd2 = new MySqlCommand("select * from akademik.login where user_id='" + this.usertext.Text + "' and pass='" + this.passtext.Text + "' and left('" + this.usertext.Text + "',2)='02';", connect);

                        MySqlDataReader myRead3;

                        myRead3 = Cmd2.ExecuteReader();
                        int count3 = 0;
                        while (myRead3.Read())
                        {
                            count3 += 1;
                        }
                        if (count3 == 1)
                        {
                            Formguru form3 = new Formguru();
                            form3.Show();
                            this.Hide();
                        }
                        else
                        {
                            myRead3.Close();
                            MySqlCommand Cmd3 = new MySqlCommand("select * from akademik.login where user_id='" + this.usertext.Text + "' and pass='" + this.passtext.Text + "' and left('" + this.usertext.Text + "',2)='03';", connect);

                            MySqlDataReader myRead4;

                            myRead4 = Cmd3.ExecuteReader();
                            int count4 = 0;
                            while (myRead4.Read())
                            {
                                count4 += 1;
                            }
                            if (count4 == 1)
                            {
                                Formstaff form4 = new Formstaff();
                                form4.Show();
                                this.Hide();
                            }
                            else
                            {
                                myRead4.Close();
                                MySqlCommand Cmd4 = new MySqlCommand("select * from akademik.login where user_id='" + this.usertext.Text + "' and pass='" + this.passtext.Text + "' and left('" + this.usertext.Text + "',2)='04';", connect);

                                MySqlDataReader myRead5;

                                myRead5 = Cmd4.ExecuteReader();
                                int count5 = 0;
                                while (myRead5.Read())
                                {
                                    count5 += 1;
                                }
                                if (count5 == 1)
                                {
                                    Form5 form5 = new Form5();
                                    form5.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Username or Password are Incorrect");
                                }
                            }
                        }
                    }
                }
                else{
                    MessageBox.Show("Username or Password are Incorrect");
                }
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
