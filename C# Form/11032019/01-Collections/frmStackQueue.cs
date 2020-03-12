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
    public partial class frmStackQueue : Form
    {
        public frmStackQueue()
        {
            InitializeComponent();
        }



        Queue halay = new Queue();
        private void btnQueueEkle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            halay.Enqueue("mustafa");
            halay.Enqueue(45);
            halay.Enqueue(DateTime.Now);
            halay.Enqueue(false);

            foreach (object item in halay)
            {
                listBox1.Items.Add(item);
            }
        //Queue => halay başıdır .İlk giren ilk çıkar((FİFO) First in first out mantıgi işe çalışır.)
        }

        private void btnenqueue_Click(object sender, EventArgs e)
        {
            //Dequeue => birinci elemandan başlayarak elenmanları verir her verdiği elemanı sonra siler.
            MessageBox.Show("Sıradaki elemanı verir , ama siler "+ halay.Dequeue());
            listBox1.Items.Clear();
            foreach (object item in halay)
            {
                listBox1.Items.Add(item);
            }
            MessageBox.Show("sıradaki elemanı verir , ama silmez" + halay.Peek());
            //Peek => sadece en üstteki elemanı verir
            listBox1.Items.Clear();
            foreach (object item in halay)
            {
                listBox1.Items.Add(item);
            }
        }

        Stack kitapYigini = new Stack();

        private void btnstackEkle_Click(object sender, EventArgs e)
        {
            kitapYigini.Push("Mustafa");
            kitapYigini.Push(767);
            kitapYigini.Push(45.4M);
            kitapYigini.Push('%');
            kitapYigini.Push("Muharrem");


            foreach (object item in kitapYigini)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnstackElemanlar_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sıradaki elamanı ver sonrası siler " + kitapYigini.Pop());
            //listBox1.Items.Clear();
            //foreach (object item in kitapYigini)
            //{
            //    listBox1.Items.Add(item);
            //}

            MessageBox.Show("Sıradaki elamanı ver sonrası silmez " + kitapYigini.Peek());
            listBox1.Items.Clear();
            foreach (object item in kitapYigini)
            {
                listBox1.Items.Add(item);
            }


        }
    }
}
