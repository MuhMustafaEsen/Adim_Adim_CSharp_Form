using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElemanlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] veriler;
        string[] sporDali;
       
        string[] futbolTakimlari;
        string[] basketTakimlari;
        string[] voleybolTakmlari;
        string[] tenisciler;
                                             
        private void Form1_Load(object sender, EventArgs e)
        {
            futbolTakimlari = new string[] { "Galatasaray", "Fenerbahçe", "Beşiktaş", "Ankaragücü", "Göztepe", "Konyaspo", "Erzurumspor" };
            basketTakimlari = new string[] { "Anadolu Efes", "Fenerbahçe", "Beşiktaş", "Ormanspor", "Galatasaray", "Daçka" };
            voleybolTakmlari = new string[] { "Fenerbahçe", "Arkas", "Galatasaray", "Ziraat Bankası", "HalkBankasi", "Tokat Belediyesi" };
            tenisciler = new string[] { "Rafael Nadal", "Novak Djokovic", "Stanislas Wawrinka", "Juan Martin del Potro", "David Ferrer", "Andy Murray",
                                                "Serena Williams","Victoria Azarenka","Li Na"};
            sporDali = new string[] {"Futbol","Basketbol","Voleybol","Tenis" };
            veriler = new string[]{ "mustafa", "dilara", "muharrem", "mehmet","cihan","gizem" };
            listBox1.DataSource = veriler;
            foreach (var item in sporDali)
            {
                comboBox1.Items.Add(item);
            }
            /*veya boyle doldurabiliriz.
             comboBox1.DataSource = sporDali;
             */
        }
        //Listbox Ornek
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString());
        }
        //ProgressBar Ornek
        private void txtMetin_TextChanged(object sender, EventArgs e)
        {
            int deger = txtMetin.Text.Length;
            pbIlerle.Value = deger;
            if (deger == 100)
            {
                MessageBox.Show("Çok yazdın");
            }
        }
        //Combobox Ornek
        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    foreach (var item in futbolTakimlari)
                    {
                        
                        comboBox2.Items.Add(item);
                    }
                    break;
                case 1:
                    foreach (var item in basketTakimlari)
                    {
                        
                        comboBox2.Items.Add(item);
                    }
                    break;
                case 2:
                    foreach (var item in voleybolTakmlari)
                    {
                       
                        comboBox2.Items.Add(item);
                    }
                    break;
                case 3:
                    foreach (var item in tenisciler)
                    {
                        
                        comboBox2.Items.Add(item);
                    }
                    break;
                
                   
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedValue.ToString() + " ismindeki kişi " + comboBox1.SelectedItem.ToString() + " spor dalini " + comboBox2.SelectedItem.ToString() + " takımını veya sporcusunu seçti");

        }
        //Event Ornek
        void Yaz(string eventAdi)
        {
            listBox2.Items.Add($"{DateTime.Now},{eventAdi}");
            listBox2.SelectedIndex = -1;
        }


        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Yaz("MouseClick");
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Yaz("MouseDoubleClick");
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Yaz("MouseDown");
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //  Yaz("MouseEnter");
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Yaz("MouseHover");
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Yaz("MouseLeave");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            //Yaz("MouseMove");
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("MouseUp");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }
        //Checkbox Ornek
        private void button5_Click(object sender, EventArgs e)
        {
            string bildigimDiller = "";
            foreach (Control item in groupBox5.Controls)//hangi groupboxta oldugu onemli
            {
                if (item is CheckBox)
                {
                CheckBox check = (CheckBox)item;
                if (check.Checked)
                {
                    bildigimDiller += check.Text + ",";
                }
                }
            }
            MessageBox.Show("Bu kişinin bildigi diller : " + bildigimDiller);
        }
        //RadioButton Ornek
        private void button6_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                MessageBox.Show(radioButton2.Text);
            }
        }
    }
}
