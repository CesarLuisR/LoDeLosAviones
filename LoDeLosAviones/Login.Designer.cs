namespace LoDeLosAviones
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Nombre = new TextBox();
            Contrasena = new TextBox();
            entrar = new Button();
            label6 = new Label();
            registrarse = new Button();
            panel2 = new Panel();
            avion = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)avion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(244, 231);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(190, 37);
            label3.TabIndex = 1;
            label3.Text = "Iniciar sesión";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(203, 290);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 23);
            label4.TabIndex = 2;
            label4.Text = "Nombre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(203, 363);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 3;
            label5.Text = "Contraseña";
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.Info;
            Nombre.Location = new Point(203, 323);
            Nombre.Margin = new Padding(2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(264, 27);
            Nombre.TabIndex = 32;
            // 
            // Contrasena
            // 
            Contrasena.BackColor = SystemColors.Info;
            Contrasena.Location = new Point(203, 395);
            Contrasena.Margin = new Padding(2);
            Contrasena.Name = "Contrasena";
            Contrasena.PasswordChar = '*';
            Contrasena.Size = new Size(264, 27);
            Contrasena.TabIndex = 33;
            // 
            // entrar
            // 
            entrar.Location = new Point(178, 450);
            entrar.Margin = new Padding(2);
            entrar.Name = "entrar";
            entrar.Size = new Size(133, 32);
            entrar.TabIndex = 34;
            entrar.Text = "Entrar";
            entrar.UseVisualStyleBackColor = true;
            entrar.Click += entrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(329, 456);
            label6.Name = "label6";
            label6.Size = new Size(20, 20);
            label6.TabIndex = 35;
            label6.Text = "O";
            // 
            // registrarse
            // 
            registrarse.Location = new Point(363, 450);
            registrarse.Margin = new Padding(2);
            registrarse.Name = "registrarse";
            registrarse.Size = new Size(133, 32);
            registrarse.TabIndex = 36;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registrarse_Click;
            // 
            // panel2
            // 
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(registrarse);
            panel2.Controls.Add(avion);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(entrar);
            panel2.Controls.Add(Contrasena);
            panel2.Controls.Add(Nombre);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1037, 540);
            panel2.TabIndex = 38;
            panel2.Paint += panel2_Paint;
            // 
            // avion
            // 
            avion.BackColor = Color.FromArgb(255, 128, 128);
            avion.Image = Properties.Resources.image;
            avion.Location = new Point(-162, 33);
            avion.Name = "avion";
            avion.Size = new Size(182, 192);
            avion.SizeMode = PictureBoxSizeMode.Zoom;
            avion.TabIndex = 39;
            avion.TabStop = false;
            avion.Click += pictureBox4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-75, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_10_abr_2025__16_23_211;
            pictureBox1.Location = new Point(142, 157);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 395);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(495, 256);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(211, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.ChatGPT_Image_9_abr_2025__20_15_001;
            pictureBox5.Location = new Point(534, 339);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(144, 268);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 41;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.ChatGPT_Image_9_abr_2025__20_15_002;
            pictureBox4.Location = new Point(-101, 323);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(274, 351);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(672, 540);
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "Login";
            StartPosition = FormStartPosition.CenterParent;
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)avion).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Nombre;
        private TextBox Contrasena;
        private Button entrar;
        private Label label6;
        private Button registrarse;
        private Button button1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox avion;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
