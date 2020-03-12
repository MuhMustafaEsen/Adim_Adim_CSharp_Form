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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            frmColor frm = new frmColor();
            DialogResult result = frm.ShowDialog();
            if(result==DialogResult.OK)
            {
                this.BackColor = frm.backColor;
            }
        }
    }
}
