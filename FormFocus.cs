using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Therapheye
{
    public partial class FormFocus : Form
    {
        public FormFocus()
        {
            InitializeComponent();
        }

        private void FormFocus_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlAcercarAlejar1.Visible = true;
            controlAcercarAlejar1.BringToFront();
        }
    }
}
