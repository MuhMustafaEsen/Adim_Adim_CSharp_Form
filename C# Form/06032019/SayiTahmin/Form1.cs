using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiTahmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bu oyunda sizin aklınızda tuttugunuz sayiyi bilgisayara buldurma işlemi
        //bu işlemde arlıkları daraltarak tuttugunuz sayiyi buttonlar yardımıyla bilgisayara buldurtuyoruz.
        int altDeger = 0;
        int ustDeger = 100;
        int tahmin = 0;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            sayac = 0;
            altDeger = 0;
            ustDeger = 100;
            tahmin = (altDeger + ustDeger) / 2;
            label3.Text = tahmin.ToString();
            label2.Text = sayac.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayac++;
            altDeger = tahmin;
            tahmin = (altDeger + ustDeger) / 2;
            label3.Text = tahmin.ToString();
            label2.Text = sayac.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayac++;
            ustDeger = tahmin;
            tahmin = (altDeger + ustDeger) / 2;
            label3.Text = tahmin.ToString();
            label2.Text = sayac.ToString();
        }
    }
}
