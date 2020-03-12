using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Islemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        double sonuc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "+":
                    sonuc = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                break;
                    case "-":
                    sonuc = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                    break;
                case "*":
                    sonuc = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                    break;
                case "/":
                    sonuc = double.Parse(textBox1.Text) / double.Parse(textBox2.Text);
                    break;
                case "%":
                    sonuc = int.Parse(textBox1.Text) % int.Parse(textBox2.Text);
                    break;
            }
            textBox3.Text = sonuc.ToString();
        }
    }
}
