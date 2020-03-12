using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_MDISample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd frm = new frmAdd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void listeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList frm = new frmList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void guncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate frm = new frmUpdate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void hakkımızdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.MdiParent = this;
            frm.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContact frm = new frmContact();
            frm.MdiParent = this;
            frm.Show();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
