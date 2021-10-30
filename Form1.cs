using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Therapheye
{
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlInicio2.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            controlInicio2.BringToFront();
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e) 
        { 
            SidePanel.Height = button2.Height;
            SidePanel.Top = button2.Top;
            controlTestInicial2.Visible = true;
            controlTestInicial2.BringToFront();
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EjercicioMovimiento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Value Eyes: Evaluación y recomendaciones para la fatiga visual y vision escotópica", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button5.Height;
            SidePanel.Top = button5.Top;
            controlEjercicios1.BringToFront();
            controlEjercicios1.Visible = true;
            controlInicio2.Visible = false;
            controlTestInicial2.Visible = false;
            controlTestFinal1.Visible = false;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button6.Height;
            SidePanel.Top = button6.Top;
            controlTestFinal1.BringToFront();
            controlTestInicial2.Visible = false;
            controlEjercicios1.Visible = false;
            controlInicio2.Visible = false;
            controlTestFinal1.Visible = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void controlEjercicios1_Load(object sender, EventArgs e)
        {

        }

        private void controlTestFinal1_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            String fecha = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            

            //textBox1.Text.Contains(fecha);
            textBox1.AppendText(fecha);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-ES");
            String hora = DateTime.Now.ToString("hh:mm tt", CultureInfo.InvariantCulture);
            textBox2.AppendText(hora);
        }
    }
   
}
