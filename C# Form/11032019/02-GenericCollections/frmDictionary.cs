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
    public partial class frmDictionary : Form
    {


        public frmDictionary()
        {
            InitializeComponent();
        }

        Dictionary<string, string> veri = new Dictionary<string, string>();
        private void btnVeri_Click(object sender, EventArgs e)
        {
            veri.Add("txt", "Not Defteri");
            veri.Add("bmp", "Paint");
            veri.Add("rtf", "Wordpad");
            Listele();
        }

        void Listele()
        {
            lstKeyValue.Items.Clear();
            ICollection<string> anahtar = veri.Keys;
            foreach (string item in anahtar)
            {
                lstKeyValue.Items.Add(item + "-" + veri[item]);
            }

        }

        private void btnOgrenci_Click(object sender, EventArgs e)
        {
            //dictionary => Collection yapısının hem generic hemde key value deger tutan yapısıdır. Dictionary yapısı bize hem keyin tipini belirleme hem value'nun tipini belirleme imkanı sunar. key yapısının kullanılma sebebi List yapısında bulunan index degerinin yeterli gelmediği durumlarda kendi index yapımızı oluşturmaktır 
            //Hastable generic ve daha hızlı hali denilebilir.
            //her bir eleman KeyValuePair tipindedir.
            

            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();
            ogrenciler.Add(1, "Mustafa");
            ogrenciler.Add(2, "Agah");
            ogrenciler.Add(3, "Muharrem");
            ogrenciler.Add(4, "Gamze");
            ogrenciler.Add(5, "Dilara");

            foreach (KeyValuePair<int, string> item in ogrenciler)
            {
                lstKeyValue.Items.Add(item.Key + " - " + item.Value);
            }

            //guid.NewGuid()=> unique(essiz , tek ) rakam ve harflerden oluşan veri oluşturur.

            //Dictionary<Guid, string> ogrenciler = new Dictionary<Guid, string>();
            //ogrenciler.Add(Guid.NewGuid(), "Mustafa");
            //ogrenciler.Add(Guid.NewGuid(), "Agah");
            //ogrenciler.Add(Guid.NewGuid(), "Muharrem");
            //ogrenciler.Add(Guid.NewGuid(), "Gamze");
            //ogrenciler.Add(Guid.NewGuid(), "Dilara");

            //foreach (KeyValuePair<Guid, string> item in ogrenciler)
            //{
            //    listBox1.Items.Add(item.Key + " - " + item.Value);



        }

        private void button9_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> paraciklar = new Dictionary<string, double>();
            paraciklar.Add("Dolar", 5.46);
            paraciklar.Add("Euro", 6.17);
            paraciklar.Add("Sterlin", 7.14);
            paraciklar.Add("Cin Yuan", 3);
            paraciklar.Add("Kanada Doları", 4.08);

            double dolarRate = paraciklar["Dolar"];
            MessageBox.Show(dolarRate.ToString());

            foreach (KeyValuePair<string, double> item in paraciklar)
            {
                lstKeyValue.Items.Add($"Para birimi {item.Key} => {item.Value}");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            veri.Add(txtKey.Text, txtValue.Text);
            Listele();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            veri.Remove(txtKey.Text);
            Listele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int adet =veri.Count();
            MessageBox.Show(adet.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(veri.ContainsValue(txtValue.Text))
            {
                MessageBox.Show($"aranılan {txtValue.Text} degeri var");
            }
            else
            {
                MessageBox.Show($"aranılan {txtValue.Text} degeri yok");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (veri.ContainsKey(txtKey.Text))
            {
                MessageBox.Show($"aranılan {txtKey.Text} degeri var");
            }
            else
            {
                MessageBox.Show($"aranılan {txtKey.Text} degeri yok");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            veri.Clear();
            Listele();
        }
    }
}
