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
            label1 = new Label();
            nombre = new TextBox();
            password = new TextBox();
            passwordL = new Label();
            confirmar = new TextBox();
            label2 = new Label();
            crear = new Button();
            volver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 139);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // nombre
            // 
            nombre.Location = new Point(272, 136);
            nombre.Name = "nombre";
            nombre.Size = new Size(125, 27);
            nombre.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(272, 181);
            password.Name = "password";
            password.Size = new Size(125, 27);
            password.TabIndex = 3;
            // 
            // passwordL
            // 
            passwordL.AutoSize = true;
            passwordL.Location = new Point(183, 184);
            passwordL.Name = "passwordL";
            passwordL.Size = new Size(83, 20);
            passwordL.TabIndex = 2;
            passwordL.Text = "Contrasena";
            // 
            // confirmar
            // 
            confirmar.Location = new Point(272, 223);
            confirmar.Name = "confirmar";
            confirmar.Size = new Size(125, 27);
            confirmar.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(115, 230);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 4;
            label2.Text = "Confirmar contrasena";
            // 
            // crear
            // 
            crear.Location = new Point(194, 331);
            crear.Name = "crear";
            crear.Size = new Size(94, 29);
            crear.TabIndex = 6;
            crear.Text = "Crear";
            crear.UseVisualStyleBackColor = true;
            crear.Click += crear_Click;
            // 
            // volver
            // 
            volver.Location = new Point(346, 331);
            volver.Name = "volver";
            volver.Size = new Size(94, 29);
            volver.TabIndex = 7;
            volver.Text = "Volver";
            volver.UseVisualStyleBackColor = true;
            volver.Click += volver_Click;
            // 
            // RegistrarseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}