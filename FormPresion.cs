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
    public partial class FormPresion : Form
    {
        public FormPresion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlPresionSimple1.Visible = true;
            controlPresionSimple1.BringToFront();
        }

        private void controlPresionSimple1_Load(object sender, EventArgs e)
        {

        }
    }
}
