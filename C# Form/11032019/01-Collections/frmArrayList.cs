using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Collections
{
    public partial class frmArrayList : Form
    {
        public frmArrayList()
        {
            InitializeComponent();
        }   //ArrayList
            //Suana kadar gördüğünüz ilkel dizilerde veri tipi bildirmek zorunluydu. 
            //arraylist bu zorunluluğu ortadan kaldırır ancak bilinmesi gereken ayrıntı her veriyi object tipinde oluşturmasıdır(Boxing-Unboxing).
            //bunun yanında kendisi kapasitesini otomatik arttırdığı(x2) için bir eleman sınırlaması da yoktur
            //arraylist kullanmak istiyorsanız usinglere System.Collections; ibaresini eklemelisiniz.

        ArrayList arrayList = new ArrayList();
        ArrayList sehirler = new ArrayList();
       

        void Listele()
        {
            lstOynanmıs.Items.Clear();
            foreach (object item in sehirler)
            {
                lstOynanmıs.Items.Add(item);
            }

        }
        private void frmArrayList_Load(object sender, EventArgs e)
        {
            //bir ArrayListe eleman eklemeniz gerektiğinde Add metodunu kullanırsınız
            arrayList.Add("bilge adam");
            arrayList.Add(true);
            arrayList.Add(45);
            arrayList.Add(1.34M);
            arrayList.Add('#');
            arrayList.Add("Gizem");
            arrayList.Add("Sarıyer");

            //arraylist içerisindeki elemanlara işlem uygulamanın iki farklı yolu vardır 
            //1)
            //foreach (object item in arrayList)
            //{
            //    lstOrijinal.Items.Add(item);
            //}

            //2)
            //lstOynanmıs.Items.AddRange(arrayList.ToArray());

            //ArrayListler index mantığı güderler bu sebeple var olan bir elemana indexi üzerinden ulaşabilirsiniz ancak unboxing işlemi uygulamanız gerekir.

            //string arrayListBirinciEleman =arrayList[0].ToString();
            //MessageBox.Show(arrayListBirinciEleman);

            sehirler.Add("İstanbul");
            sehirler.Add("İzmit");
            sehirler.Add("Adana");
            sehirler.Add("Kırşehir");
            sehirler.Add("Sarıyer");
            sehirler.Add("Malatya");
            sehirler.Add("Mersin");
            sehirler.Add("Antalya");
            sehirler.Add("Konya");

            foreach (object item in sehirler)
            {
                lstOrijinal.Items.Add(item);
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //girilen deger null veya boş değilse ekle
            if(!string.IsNullOrEmpty(txtValue.Text))
            {
                sehirler.Add(txtValue.Text);
                Listele();
            }
            else
            {
                MessageBox.Show("Lütfen veri giriniz");
            }
      
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //textboxtan girilen ve Arraylistin içinde bulunan elemanı siliniz.
            sehirler.Remove(txtValue.Text);
            Listele();
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            //txtboxtan girilen deger arrayListte varsa var yoksa yok mboxı döndür.
            string deger = txtValue.Text;
            if (sehirler.Contains(deger))
            {
                MessageBox.Show($"{deger} arrayListte var");
            }
            else
            {
                MessageBox.Show(deger + " arrayListte yok ");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //birinci indexe bir sehir ekleyip listeleyiniz.
            sehirler.Insert(1, txtValue.Text);
            Listele();

        }
        ArrayList ulkeler = new ArrayList();
        private void btnArrayList_Click(object sender, EventArgs e)
        {
            ulkeler.Add(txtValue.Text);
            lstOrijinal.Items.Clear();
            foreach (object item in ulkeler)
            {
                lstOrijinal.Items.Add(item);
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ulkeler.Count.ToString());
        }

        private void btnCapacity_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ulkeler.Capacity.ToString());
        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            //arraylistin kapasitesini var olan eleman sayısına eşitleyiniz.
            ulkeler.TrimToSize();
            
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            //sehirleri sıralayınız.
            sehirler.Sort();
            sehirler.Reverse();
            Listele();

            arrayList.Sort();
            Listele();
        }
    }
}
