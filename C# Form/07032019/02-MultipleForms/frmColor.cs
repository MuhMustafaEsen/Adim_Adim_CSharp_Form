using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MultipleForms
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void frmColor_Load(object sender, EventArgs e)
        {
            cmbRenkler.Items.Add(Color.Beige);
            cmbRenkler.Items.Add(Color.Azure);
            cmbRenkler.Items.Add(Color.Black);
            cmbRenkler.Items.Add(Color.BlueViolet);
            cmbRenkler.Items.Add(Color.Coral);
        }
        public frmMain mainForm;
        private void cmbRenkler_SelectedIndexChanged(object sender, EventArgs e)
        {
            //hatalı
            //frmMain frm = new frmMain();
            //frm.BackColor = (Color)cmbRenkler.SelectedItem;
            //frm.Show();

            mainForm.BackColor = (Color)cmbRenkler.SelectedItem;
        }
    }
}
