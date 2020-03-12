using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Showlamaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            new Form().Show();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            new Form().ShowDialog();
        }

        private void btnMbox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deneme");
        }
    }
}
