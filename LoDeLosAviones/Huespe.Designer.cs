﻿namespace LoDeLosAviones
{
    partial class Huespe
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button3 = new Button();
            adultos = new Label();
            Ninos = new Label();
            listo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Habitación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Adultos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 150);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Niños";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(308, 80);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(43, 34);
            button1.TabIndex = 3;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(416, 80);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(42, 34);
            button2.TabIndex = 4;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(308, 150);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(43, 34);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(416, 151);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(42, 34);
            button3.TabIndex = 7;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // adultos
            // 
            adultos.AutoSize = true;
            adultos.Location = new Point(362, 88);
            adultos.Margin = new Padding(2, 0, 2, 0);
            adultos.Name = "adultos";
            adultos.Size = new Size(0, 20);
            adultos.TabIndex = 8;
            // 
            // Ninos
            // 
            Ninos.AutoSize = true;
            Ninos.Location = new Point(355, 161);
            Ninos.Margin = new Padding(2, 0, 2, 0);
            Ninos.Name = "Ninos";
            Ninos.Size = new Size(0, 20);
            Ninos.TabIndex = 9;
            // 
            // listo
            // 
            listo.ForeColor = SystemColors.MenuHighlight;
            listo.Location = new Point(308, 245);
            listo.Margin = new Padding(2);
            listo.Name = "listo";
            listo.Size = new Size(185, 42);
            listo.TabIndex = 10;
            listo.Text = "listo";
            listo.UseVisualStyleBackColor = true;
            listo.Click += listo_Click;
            // 
            // Huespe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 430);
            Controls.Add(listo);
            Controls.Add(Ninos);
            Controls.Add(adultos);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Huespe";
            Text = "Huespe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button3;
        private Label adultos;
        private Label Ninos;
        private Button listo;
    }
}