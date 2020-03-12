using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void frmColor_Load(object sender, EventArgs e)
        {
            cmbRenkler.Items.Add(Color.Chartreuse);
            cmbRenkler.Items.Add(Color.Coral);
            cmbRenkler.Items.Add(Color.Cyan);
            cmbRenkler.Items.Add(Color.Fuchsia);
            cmbRenkler.Items.Add(Color.Aqua);
        }
        public Color backColor;
        private void btnOK_Click(object sender, EventArgs e)
        {
            backColor =(Color)cmbRenkler.SelectedItem;
            this.DialogResult = DialogResult.OK;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
