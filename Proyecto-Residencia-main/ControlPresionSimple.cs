﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Media;
using System.IO;

namespace Therapheye
{
    public partial class ControlPresionSimple : UserControl
    {
        Stopwatch reloj = new Stopwatch();

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

        private void button1_Click(object sender, EventArgs e)
        {
            reloj.Start();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)reloj.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length<2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length<2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMil.Text = ts.Milliseconds.ToString();

           
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\Gena4\Documents\Audacity\doorbell2-6450.wav");
            System.Media.SoundPlayer toca = new System.Media.SoundPlayer("doorbell2-6450.wav");
            if (ts.Seconds == 4) { player.Play(); }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
