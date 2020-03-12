using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sonuc = 1;
                
                int faktoriyel = int.Parse(textBox1.Text);

                if (faktoriyel == 0)
                {
                    sonuc = 1;
                }
                for (int i = 1; i <= faktoriyel; i++)
                {
                    sonuc *= i;
                }
                label3.Text = faktoriyel + "! = " + sonuc.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Sayi gir");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(label3.Text);
            Temizle();
        }
        void Temizle()
        {
            textBox1.Text = "";
            label3.Text = "";
        }
    }
}
