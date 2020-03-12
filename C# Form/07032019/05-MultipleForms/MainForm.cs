using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_MultipleForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.Show();
        }

        public void Ekle(object item )
        {
            listBox1.Items.Add(item);
        }
    }
}
