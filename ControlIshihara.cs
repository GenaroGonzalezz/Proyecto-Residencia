﻿using System;
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
    public partial class ControlIshihara : UserControl
    {
        public ControlIshihara()
        {
            InitializeComponent();
        }

        private void ControlIshihara_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
            pictureBox5.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox6.BringToFront();
            pictureBox6.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
            pictureBox3.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            pictureBox4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
            pictureBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormVisNoc.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "12") { textBox2.BackColor = Color.Green; } else { textBox2.BackColor = Color.Red; }
            if (textBox3.Text == "74") { textBox3.BackColor = Color.Green; } else { textBox3.BackColor = Color.Red; }
            if (textBox4.Text == "6") {  textBox4.BackColor = Color.Green; } else { textBox4.BackColor = Color.Red; }
            if (textBox5.Text == "16") { textBox5.BackColor = Color.Green; } else { textBox5.BackColor = Color.Red; }
            if (textBox6.Text == "2") {  textBox6.BackColor = Color.Green; } else { textBox6.BackColor = Color.Red; }
            if (textBox7.Text == "29") { textBox7.BackColor = Color.Green; } else { textBox7.BackColor = Color.Red; }
        }
    }
}
