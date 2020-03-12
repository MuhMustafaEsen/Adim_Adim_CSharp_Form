using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_GenericCollections
{
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        List<string> isimler = new List<string>();
        private void btnIsimler_Click(object sender, EventArgs e)
        {
            isimler.Add("Gizem");
            isimler.Add("Mustafa");
            isimler.Add("Muharrem");
            isimler.Add("Ali");
            isimler.Add("Dilara");
            isimler.Add("Cihan");
            isimler.Add("Ferhunde");
            foreach (string item in isimler)
            {
                listBox1.Items.Add(item);
            }
        }
        //List<> içerisinde verilen tipe bürünerek o tipte bir koleksiyon oluşturmamıza olanak sağlayan bir collection tipidir.
        //Boyut arttırma zorunluluğu yoktur. 
        //!!!!!!!! aynı tipte veriyi bir arada tutacaksak Arrylist değil Generic list kullanmalıyız.

        private void btnEkle_Click(object sender, EventArgs e)
        {
            isimler.Add(txtIsim.Text);
            foreach (string item in isimler)
            {
                listBox2.Items.Add(item);
            }
        }
        List<int> sayilar = new List<int>() { 3, 4, 5, 6, 7, 8, 9, 0, 2, 4, 6, 9 };
        private void btnSayilar_Click(object sender, EventArgs e)
        {

            foreach (int item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                sayilar.Add(int.Parse(txtIsim.Text));
                foreach (int item in sayilar)
                {
                    listBox2.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            sayilar.Sort();
            foreach (int item in sayilar)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int elemanSayisi = sayilar.Count();
            MessageBox.Show("sayilar dizisinin eleman sayisi" + elemanSayisi);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sayilar.Insert(3, 7);
            foreach (int item in sayilar)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            sayilar.Clear();
            MessageBox.Show(sayilar.Count.ToString());
            listBox1.Items.Clear();
            foreach (int item in sayilar)
            {
                listBox1.Items.Add(item);
            }

        }

        private void btnreverse_Click(object sender, EventArgs e)
        {
            sayilar.Reverse();
            foreach (int item in sayilar)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            if (sayilar.Contains(100))
            {
                MessageBox.Show("içeriyor");
            }
            else
                MessageBox.Show("içermiyor");
        }

        private void frmList_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (int item in sayilar)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> number = new List<int>();
            number.AddRange(sayilar);
          
            foreach (int item in number)
            {
                listBox2.Items.Add(item);
            }
        }
    }
}
