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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Nombre = new TextBox();
            Contrasena = new TextBox();
            entrar = new Button();
            label6 = new Label();
            registrarse = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 38, 70);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 66);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(343, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(28, 28);
            label2.TabIndex = 1;
            label2.Text = "--";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(386, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(121, 119);
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
            label4.Location = new Point(78, 192);
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
            label5.Location = new Point(78, 265);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 23);
            label5.TabIndex = 3;
            label5.Text = "Contraseña";
            // 
            // Nombre
            // 
            Nombre.BackColor = SystemColors.Info;
            Nombre.Location = new Point(78, 225);
            Nombre.Margin = new Padding(2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(264, 27);
            Nombre.TabIndex = 32;
            // 
            // Contrasena
            // 
            Contrasena.BackColor = SystemColors.Info;
            Contrasena.Location = new Point(78, 297);
            Contrasena.Margin = new Padding(2);
            Contrasena.Name = "Contrasena";
            Contrasena.PasswordChar = '*';
            Contrasena.Size = new Size(264, 27);
            Contrasena.TabIndex = 33;
            // 
            // entrar
            // 
            entrar.Location = new Point(53, 352);
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
            label6.Location = new Point(204, 358);
            label6.Name = "label6";
            label6.Size = new Size(20, 20);
            label6.TabIndex = 35;
            label6.Text = "O";
            // 
            // registrarse
            // 
            registrarse.Location = new Point(238, 352);
            registrarse.Margin = new Padding(2);
            registrarse.Name = "registrarse";
            registrarse.Size = new Size(133, 32);
            registrarse.TabIndex = 36;
            registrarse.Text = "Registrarse";
            registrarse.UseVisualStyleBackColor = true;
            registrarse.Click += registrarse_Click;
            // 
            // button1
            // 
            button1.Location = new Point(192, 442);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 37;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 59, 104);
            ClientSize = new Size(434, 564);
            Controls.Add(button1);
            Controls.Add(registrarse);
            Controls.Add(label6);
            Controls.Add(entrar);
            Controls.Add(Contrasena);
            Controls.Add(Nombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(2);
            Name = "Login";
            Text = "Registro";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox Nombre;
        private TextBox Contrasena;
        private Button entrar;
        private Label label6;
        private Button registrarse;
        private Button button1;
    }
}
