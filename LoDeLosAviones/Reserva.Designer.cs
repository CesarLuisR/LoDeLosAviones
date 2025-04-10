namespace LoDeLosAviones
{
    partial class Reserva
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Captura_de_pantalla_2025_04_09_224737;
            pictureBox1.Location = new Point(281, 109);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(446, 234);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(281, 365);
            label1.Name = "label1";
            label1.Size = new Size(213, 48);
            label1.TabIndex = 1;
            label1.Text = "Hotel César";
            // 
            // button1
            // 
            button1.Location = new Point(510, 654);
            button1.Name = "button1";
            button1.Size = new Size(230, 31);
            button1.TabIndex = 4;
            button1.Text = "hab., huésped";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(375, 741);
            button2.Name = "button2";
            button2.Size = new Size(188, 45);
            button2.TabIndex = 5;
            button2.Text = "Reservar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(202, 654);
            button4.Name = "button4";
            button4.Size = new Size(230, 31);
            button4.TabIndex = 7;
            button4.Text = "Fecha de reserva";
            button4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 446);
            label2.Name = "label2";
            label2.Size = new Size(308, 30);
            label2.TabIndex = 8;
            label2.Text = "Información de la propiedad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 545);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(364, 25);
            label3.TabIndex = 9;
            label3.Text = "Estacionamiento sin valet parking disponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(136, 502);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(232, 25);
            label4.TabIndex = 10;
            label4.Text = "Desayuno buffet disponible";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(558, 545);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(276, 25);
            label5.TabIndex = 11;
            label5.Text = "Tratamientos corporales en el spa";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(576, 502);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(92, 25);
            label6.TabIndex = 12;
            label6.Text = "Wifi gratis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(136, 588);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(215, 25);
            label7.TabIndex = 13;
            label7.Text = "Restaurante mediterráneo";
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 819);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Reserva";
            Text = "Reserva";
            Load += Reserva_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}