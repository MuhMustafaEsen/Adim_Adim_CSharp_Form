using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeniYakala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yakaladin");
        }
        Random rnd = new Random();
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            int rastgeleX = rnd.Next(0, this.Width - button1.Width - 30);
            int rastgeleY = rnd.Next(0, this.Height - button1.Height - 30);

            button1.Left = rastgeleX;
            button1.Top = rastgeleY;
        }
    }
}
