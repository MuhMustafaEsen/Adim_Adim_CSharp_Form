using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string mail = textBox1.Text;
                string pass = textBox2.Text;
                if (mail == "admin@admin.com")
                {
                    if (pass == "123")
                    {
                        MessageBox.Show("Welcome Admin");
                    }
                    else
                    {
                        MessageBox.Show("şifre yanlış");
                    }
                }
                else if (mail == "user@user.com")
                {
                    if (pass == "1234")
                    {
                        MessageBox.Show("Hoşgeldin User");
                    }
                    else
                    {
                        MessageBox.Show("şifre yanlış");
                    }

                }
                else
                {
                    MessageBox.Show("get out!!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
