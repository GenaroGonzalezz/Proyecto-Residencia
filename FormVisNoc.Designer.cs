
namespace Therapheye
{
    partial class FormVisNoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.controlAmsler1 = new Therapheye.ControlAmsler();
            this.controlIshihara1 = new Therapheye.ControlIshihara();
            this.controlPelli1 = new Therapheye.ControlPelli();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 395);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Visión del color";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sensibilidad de contraste";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(12, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "Degeneración Macular";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // controlAmsler1
            // 
            this.controlAmsler1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlAmsler1.Location = new System.Drawing.Point(206, 3);
            this.controlAmsler1.Name = "controlAmsler1";
            this.controlAmsler1.Size = new System.Drawing.Size(735, 394);
            this.controlAmsler1.TabIndex = 3;
            this.controlAmsler1.Visible = false;
            // 
            // controlIshihara1
            // 
            this.controlIshihara1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlIshihara1.Location = new System.Drawing.Point(201, 1);
            this.controlIshihara1.Name = "controlIshihara1";
            this.controlIshihara1.Size = new System.Drawing.Size(749, 394);
            this.controlIshihara1.TabIndex = 2;
            this.controlIshihara1.Visible = false;
            this.controlIshihara1.Load += new System.EventHandler(this.controlIshihara1_Load);
            // 
            // controlPelli1
            // 
            this.controlPelli1.AutoSize = true;
            this.controlPelli1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
            this.controlPelli1.Location = new System.Drawing.Point(202, 1);
            this.controlPelli1.Name = "controlPelli1";
            this.controlPelli1.Size = new System.Drawing.Size(748, 396);
            this.controlPelli1.TabIndex = 1;
            this.controlPelli1.Visible = false;
            this.controlPelli1.Load += new System.EventHandler(this.controlPelli1_Load);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(232)))), ((int)(((byte)(186)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(12, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(177, 51);
            this.button4.TabIndex = 4;
            this.button4.Text = "Degeneración Macular";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // FormVisNoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 395);
            this.Controls.Add(this.controlAmsler1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlIshihara1);
            this.Controls.Add(this.controlPelli1);
            this.Name = "FormVisNoc";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visión Nocturna";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private ControlPelli controlPelli1;
        private System.Windows.Forms.Button button2;
        private ControlIshihara controlIshihara1;
        private System.Windows.Forms.Button button3;
        private ControlAmsler controlAmsler1;
        private System.Windows.Forms.Button button4;
    }
}