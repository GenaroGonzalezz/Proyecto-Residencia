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
    public partial class ControlPresionSimple : UserControl
    {
        public ControlPresionSimple()
        {
            InitializeComponent();
        }

        private void ControlPresionSimple_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\Gena4\source\repos\Therapheye\Resources\Presión.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPresion.ActiveForm.Close();
        }
    }
}
