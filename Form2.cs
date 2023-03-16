using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab_09.system;

namespace lab_09
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            system.load_users();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            string user = username_tb.Text;
            string password = pass_tb.Text;
            int count = password.Length;
            string retypepass = retype.Text;

            if (system.users.Count > 0)
            {
                foreach (user u in system.users)
                {
                    if (u.username == user)
                    {

                        if (count >= 6)
                        {
                            if (password == retypepass)
                            {
                                string path = "userid.txt";
                                StreamWriter sw = File.AppendText(path);
                                user uu = new user(user, name, password);
                                system.users.Add(uu);
                                string ss = $"{user},{password},{name}";
                                sw.WriteLine(ss);
                                sw.Close();

                                Form1 f1 = new Form1();
                                f1.Show();
                                this.Hide();

                            }
                            else
                            {
                                MessageBox.Show("Passwords do not match");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Password must be 6 or more characters");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username exists. Try another");
                    }
                }
            }
            else
            {

                string path = "user.txt";
                StreamWriter sw = File.AppendText(path);
                user uu = new user(user, name, password);
                system.users.Add(uu);
                string ss = $"{user},{password},{name}";
                sw.WriteLine(ss);
                sw.Close();

                Form1 f1 = new Form1();
                f1.Show();
                this.Hide();
            }
        }
    }
}

