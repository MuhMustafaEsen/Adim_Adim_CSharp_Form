using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SehirEkleCikar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sehir = textBox1.Text;
            if (string.IsNullOrEmpty(sehir))
            {
                MessageBox.Show("sehir kısmı boş kalamaz");
            }
            else
            {
                listBox1.Items.Add(sehir);
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(listBox1.SelectedItem.ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show("lütfen listeden bir sehir seçiniz.");
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("İstanbul");
            listBox1.Items.Add("Ankara");
            listBox1.Items.Add("İzmir");
            listBox1.Items.Add("Konya");
        }
    }
}
