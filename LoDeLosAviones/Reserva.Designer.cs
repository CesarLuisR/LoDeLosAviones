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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_8_abr_2025__01_59_27_p_m_;
            pictureBox1.Location = new Point(225, 87);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 187);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(225, 294);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 41);
            label1.TabIndex = 1;
            label1.Text = "Hotel César";
            // 
            // button1
            // 
            button1.Location = new Point(408, 523);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(206, 45);
            button1.TabIndex = 4;
            button1.Text = "hab., huésped";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(300, 593);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(150, 36);
            button2.TabIndex = 5;
            button2.Text = "Reservar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(162, 523);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(203, 45);
            button4.TabIndex = 7;
            button4.Text = "Fecha de reserva";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(225, 385);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(267, 25);
            label2.TabIndex = 8;
            label2.Text = "Información de la propiedad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 452);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 9;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 350);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 10;
            label4.Text = "ubicacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(225, 422);
            label5.Name = "label5";
            label5.Size = new Size(146, 20);
            label5.TabIndex = 11;
            label5.Text = "Huespedes maximos";
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 655);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(2);
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
    }
}