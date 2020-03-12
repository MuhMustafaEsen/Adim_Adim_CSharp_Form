using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MultipleForms
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            mainForm =(MainForm)this.Owner;
        }
        MainForm mainForm;
        private void txtText_TextChanged(object sender, EventArgs e)
        {
            mainForm.SetLabel(txtText.Text);
        }
    }
}
