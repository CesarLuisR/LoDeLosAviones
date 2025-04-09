namespace LoDeLosAviones
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
            label4 = new Label();
            label5 = new Label();
            button5 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 34);
            label1.Name = "label1";
            label1.Size = new Size(126, 30);
            label1.TabIndex = 0;
            label1.Text = "Habitación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 110);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 1;
            label2.Text = "Adultos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 187);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Niños";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(385, 100);
            button1.Name = "button1";
            button1.Size = new Size(54, 42);
            button1.TabIndex = 3;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(520, 100);
            button2.Name = "button2";
            button2.Size = new Size(53, 42);
            button2.TabIndex = 4;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(385, 187);
            button4.Name = "button4";
            button4.Size = new Size(54, 42);
            button4.TabIndex = 6;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(520, 189);
            button3.Name = "button3";
            button3.Size = new Size(53, 42);
            button3.TabIndex = 7;
            button3.Text = "+";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 110);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 8;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(455, 200);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // button5
            // 
            button5.ForeColor = SystemColors.MenuHighlight;
            button5.Location = new Point(385, 306);
            button5.Name = "button5";
            button5.Size = new Size(231, 52);
            button5.TabIndex = 10;
            button5.Text = "Agregar otra habitación";
            button5.UseVisualStyleBackColor = true;
            // 
            // Huespe
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 537);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label4;
        private Label label5;
        private Button button5;
    }
}