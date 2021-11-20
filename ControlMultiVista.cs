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
    public partial class ControlMultiVista : UserControl
    {
        public ControlMultiVista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormMov.ActiveForm.Close();
        }

        private void ControlMultiVista_Load(object sender, EventArgs e)
        {
            pictureBox6.Image = Image.FromFile(@"C:\Users\Gena4\source\repos\Therapheye\Resources\Lateral.gif");
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"C:\Users\Gena4\source\repos\Therapheye\Resources\upndown.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormUpDown fud = new FormUpDown();
            fud.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormLaterales fl = new FormLaterales();
            fl.ShowDialog();
        }
    }
}
