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
    public partial class FormVisNoc : Form
    {
        public FormVisNoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlPelli1.BringToFront();
            controlPelli1.Visible = true;
            this.ControlBox = false;

            controlIshihara1.Visible = false;
            controlAmsler1.Visible = false;
        }

        private void controlPelli1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            controlIshihara1.BringToFront();
            controlIshihara1.Visible = true;
            this.ControlBox = false;

            controlPelli1.Visible = false;
        }

        private void controlIshihara1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            controlAmsler1.BringToFront();
            controlAmsler1.Visible = true;

            controlPelli1.Visible = false;
            controlIshihara1.Visible = false;
        }
    }
}
