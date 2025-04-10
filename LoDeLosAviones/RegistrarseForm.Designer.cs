namespace LoDeLosAviones
{
    partial class RegistrarseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarseForm));
            label1 = new Label();
            nombre = new TextBox();
            password = new TextBox();
            passwordL = new Label();
            confirmar = new TextBox();
            label2 = new Label();
            crear = new Button();
            volver = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(100, 120);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // nombre
            // 
            nombre.Location = new Point(195, 120);
            nombre.Name = "nombre";
            nombre.Size = new Size(125, 27);
            nombre.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(195, 165);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 3;
            // 
            // passwordL
            // 
            passwordL.AutoSize = true;
            passwordL.BackColor = Color.Transparent;
            passwordL.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            passwordL.ForeColor = SystemColors.ActiveCaptionText;
            passwordL.Location = new Point(81, 165);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(99, 23);
            passwordL.TabIndex = 2;
            passwordL.Text = "Contrasena";
            // 
            // confirmar
            // 
            confirmar.Location = new Point(195, 207);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(125, 27);
            confirmar.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(13, 211);
            label2.Name = "label2";
            label2.Size = new Size(183, 23);
            label2.TabIndex = 4;
            label2.Text = "Confirmar contrasena";
            // 
            // crear
            // 
            crear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            crear.Location = new Point(100, 265);
            crear.Name = "crear";
            crear.Size = new Size(94, 29);
            crear.TabIndex = 6;
            crear.Text = "Crear";
            crear.UseVisualStyleBackColor = true;
            crear.Click += crear_Click;
            // 
            // volver
            // 
            volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            volver.Location = new Point(255, 265);
            volver.Name = "volver";
            volver.Size = new Size(94, 29);
            volver.TabIndex = 7;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_9_abr_2025__20_15_00;
            pictureBox1.Location = new Point(403, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 433);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, -13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 130);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(195, -40);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(211, 130);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(53, 335);
            label3.Name = "label3";
            label3.Size = new Size(322, 72);
            label3.TabIndex = 11;
            label3.Text = "\"Complete el siguiente formulario para reservar su estancia y disfrutar de una experiencia inolvidable en nuestro hotel.\"";
            // 
            // RegistrarseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(volver);
            Controls.Add(crear);
            Controls.Add(confirmar);
            Controls.Add(label2);
            Controls.Add(password);
            Controls.Add(passwordL);
            Controls.Add(nombre);
            Controls.Add(label1);
            Name = "RegistrarseForm";
            Text = "RegistrarseForm";
            Load += RegistrarseForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nombre;
        private TextBox password;
        private Label passwordL;
        private TextBox confirmar;
        private Label label2;
        private Button crear;
        private Button volver;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
    }
}