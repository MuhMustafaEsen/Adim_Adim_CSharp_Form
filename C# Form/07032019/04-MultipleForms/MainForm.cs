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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            ChildForm childForm = new ChildForm();
            childForm.Owner = this;
            childForm.Show();
        }
        public void SetLabel(string text)
        {
            lbltext.Text = text;
        }
    }
}
