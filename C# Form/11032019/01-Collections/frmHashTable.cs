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
    public partial class frmHashTable : Form
    {
        public frmHashTable()
        {
            InitializeComponent();
        }

        Hashtable sozluk = new Hashtable();
        private void frmHashTable_Load(object sender, EventArgs e)
        {
            sozluk.Add("sinif", "4A");
            sozluk.Add("PI", 3223444);
            sozluk.Add(34, "İstanbul");

            sozluk["kitap"] = "book";
            sozluk["araba"] = "car";


        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DictionaryEntry entry;
            lstHashTable.Items.Clear();
            foreach (object item in sozluk)
            {
                entry = (DictionaryEntry)item;
                lstHashTable.Items.Add(entry.Key + " - " + entry.Value);
               
            }
        }

        private void btnValue_Click(object sender, EventArgs e)
        {
            ICollection deger = sozluk.Values;
            foreach (object item in deger)
            {
                lstHashTable.Items.Add(item);
            }}
        private void btnKey_Click(object sender, EventArgs e)
        {
            ICollection anahtar = sozluk.Keys;
            foreach (object item in anahtar)
            {
                lstHashTable.Items.Add(item);
            }    
        }private void btnkeyeBak_Click(object sender, EventArgs e)
        {
            if(sozluk.ContainsKey("snif"))
            {
                MessageBox.Show("bu anahtar var");
            }
            else
            {
                MessageBox.Show("bu anahtar yok");
            }

            if(sozluk.ContainsValue("adana"))
            {
                MessageBox.Show("böyle bir deger var");
            }
            else
            {
                MessageBox.Show("böyle bir deger yok");
            }
        }
    }
}
