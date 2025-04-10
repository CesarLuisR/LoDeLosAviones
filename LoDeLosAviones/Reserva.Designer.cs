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
            label1 = new Label();
            label2 = new Label();
            textBoxNombre = new TextBox();
            label3 = new Label();
            textBoxApellido = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBoxCorreo = new TextBox();
            label6 = new Label();
            comboBoxCodigo = new ComboBox();
            textBoxTelefono = new TextBox();
            label7 = new Label();
            MetodoPago = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            NumeroTarjeta = new TextBox();
            label10 = new Label();
            NombreTitular = new TextBox();
            CodigoSeguridad = new TextBox();
            label11 = new Label();
            label12 = new Label();
            FechaVencimiento = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(240, 21);
            label1.Name = "label1";
            label1.Size = new Size(343, 38);
            label1.TabIndex = 0;
            label1.Text = "¿Quién hará el check-in?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 123);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(173, 123);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(253, 31);
            textBoxNombre.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 192);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 3;
            label3.Text = "Apellido";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(173, 192);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(253, 31);
            textBoxApellido.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(161, 276);
            label4.Name = "label4";
            label4.Size = new Size(245, 28);
            label4.TabIndex = 5;
            label4.Text = "Información de contacto";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 353);
            label5.Name = "label5";
            label5.Size = new Size(157, 25);
            label5.TabIndex = 6;
            label5.Text = "Correo electrónico";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(252, 353);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(464, 31);
            textBoxCorreo.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(88, 440);
            label6.Name = "label6";
            label6.Size = new Size(79, 25);
            label6.TabIndex = 8;
            label6.Text = "Teléfono";
            // 
            // comboBoxCodigo
            // 
            comboBoxCodigo.FormattingEnabled = true;
            comboBoxCodigo.Location = new Point(188, 432);
            comboBoxCodigo.Name = "comboBoxCodigo";
            comboBoxCodigo.Size = new Size(226, 33);
            comboBoxCodigo.TabIndex = 9;
            comboBoxCodigo.SelectedIndexChanged += comboBoxCodigo_SelectedIndexChanged;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(420, 434);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(337, 31);
            textBoxTelefono.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(161, 502);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 11;
            label7.Text = "Forma de pago";
            // 
            // MetodoPago
            // 
            MetodoPago.FormattingEnabled = true;
            MetodoPago.Items.AddRange(new object[] { "Efectivo", "Tarjeta", "Transferencia", "PayPal" });
            MetodoPago.Location = new Point(252, 568);
            MetodoPago.Name = "MetodoPago";
            MetodoPago.Size = new Size(226, 33);
            MetodoPago.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 568);
            label8.Name = "label8";
            label8.Size = new Size(148, 25);
            label8.TabIndex = 13;
            label8.Text = "Método de pago";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 634);
            label9.Name = "label9";
            label9.Size = new Size(156, 25);
            label9.TabIndex = 15;
            label9.Text = "Número de tarjeta";
            label9.Click += label9_Click_1;
            // 
            // NumeroTarjeta
            // 
            NumeroTarjeta.Location = new Point(216, 634);
            NumeroTarjeta.Name = "NumeroTarjeta";
            NumeroTarjeta.Size = new Size(326, 31);
            NumeroTarjeta.TabIndex = 16;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(54, 690);
            label10.Name = "label10";
            label10.Size = new Size(157, 25);
            label10.TabIndex = 17;
            label10.Text = "Nombre del titular";
            // 
            // NombreTitular
            // 
            NombreTitular.Location = new Point(217, 687);
            NombreTitular.Name = "NombreTitular";
            NombreTitular.Size = new Size(326, 31);
            NombreTitular.TabIndex = 18;
            // 
            // CodigoSeguridad
            // 
            CodigoSeguridad.Location = new Point(230, 741);
            CodigoSeguridad.Name = "CodigoSeguridad";
            CodigoSeguridad.Size = new Size(313, 31);
            CodigoSeguridad.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(53, 744);
            label11.Name = "label11";
            label11.Size = new Size(180, 25);
            label11.TabIndex = 20;
            label11.Text = "Código de seguridad";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(53, 795);
            label12.Name = "label12";
            label12.Size = new Size(183, 25);
            label12.TabIndex = 22;
            label12.Text = "Fecha de vencimiento";
            // 
            // FechaVencimiento
            // 
            FechaVencimiento.Location = new Point(230, 792);
            FechaVencimiento.Name = "FechaVencimiento";
            FechaVencimiento.Size = new Size(313, 31);
            FechaVencimiento.TabIndex = 21;
            // 
            // Reserva
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 860);
            Controls.Add(label12);
            Controls.Add(FechaVencimiento);
            Controls.Add(label11);
            Controls.Add(CodigoSeguridad);
            Controls.Add(NombreTitular);
            Controls.Add(label10);
            Controls.Add(NumeroTarjeta);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(MetodoPago);
            Controls.Add(label7);
            Controls.Add(textBoxTelefono);
            Controls.Add(comboBoxCodigo);
            Controls.Add(label6);
            Controls.Add(textBoxCorreo);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxApellido);
            Controls.Add(label3);
            Controls.Add(textBoxNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Reserva";
            Text = "Reserva";
            Load += Reserva_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxNombre;
        private Label label3;
        private TextBox textBoxApellido;
        private Label label4;
        private Label label5;
        private TextBox textBoxCorreo;
        private Label label6;
        private ComboBox comboBoxCodigo;
        private TextBox textBoxTelefono;
        private Label label7;
        private ComboBox MetodoPago;
        private Label label8;
        private Label label9;
        private TextBox NumeroTarjeta;
        private Label label10;
        private TextBox NombreTitular;
        private TextBox CodigoSeguridad;
        private Label label11;
        private Label label12;
        private TextBox FechaVencimiento;
    }
}