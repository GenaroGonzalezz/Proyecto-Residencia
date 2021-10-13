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
            controlPelli1.Visible = true;
        }

        private void controlPelli1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
