namespace LoDeLosAviones
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            cerrarSesion = new Button();
            panel1 = new Panel();
            verReservas = new Button();
            buscar = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            presupuesto = new NumericUpDown();
            huespedes = new Button();
            ubicacion = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buscar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presupuesto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cerrarSesion
            // 
            cerrarSesion.Location = new Point(1070, 30);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(89, 29);
            cerrarSesion.TabIndex = 0;
            cerrarSesion.Text = "Cerrar sesion";
            cerrarSesion.UseVisualStyleBackColor = true;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(verReservas);
            panel1.Controls.Add(buscar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(presupuesto);
            panel1.Controls.Add(cerrarSesion);
            panel1.Controls.Add(huespedes);
            panel1.Controls.Add(ubicacion);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 94);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // verReservas
            // 
            verReservas.Location = new Point(234, 28);
            verReservas.Name = "verReservas";
            verReservas.Size = new Size(146, 29);
            verReservas.TabIndex = 19;
            verReservas.Text = "Ver reservas";
            verReservas.UseVisualStyleBackColor = true;
            // 
            // buscar
            // 
            buscar.Image = (Image)resources.GetObject("buscar.Image");
            buscar.Location = new Point(1004, 21);
            buscar.Name = "buscar";
            buscar.Size = new Size(52, 50);
            buscar.SizeMode = PictureBoxSizeMode.Zoom;
            buscar.TabIndex = 12;
            buscar.TabStop = false;
            buscar.Click += pictureBox3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(393, 30);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 18;
            label1.Text = "presupuesto";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // presupuesto
            // 
            presupuesto.Location = new Point(489, 28);
            presupuesto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(63, 27);
            presupuesto.TabIndex = 17;
            presupuesto.ValueChanged += presupuesto_ValueChanged;
            // 
            // huespedes
            // 
            huespedes.Location = new Point(571, 17);
            huespedes.Name = "huespedes";
            huespedes.Size = new Size(200, 54);
            huespedes.TabIndex = 14;
            huespedes.Text = "Huespedes";
            huespedes.UseVisualStyleBackColor = true;
            huespedes.Click += huespedes_Click;
            // 
            // ubicacion
            // 
            ubicacion.Location = new Point(782, 17);
            ubicacion.Name = "ubicacion";
            ubicacion.Size = new Size(200, 54);
            ubicacion.TabIndex = 15;
            ubicacion.Text = "Ubicacion";
            ubicacion.UseVisualStyleBackColor = true;
            ubicacion.Click += ubicacion_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(246, 124);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(920, 511);
            flowLayoutPanel1.TabIndex = 16;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(-3, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(230, 570);
            panel2.TabIndex = 20;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.WhatsApp_Image_2025_04_10_at_2_33_22_PM;
            pictureBox3.Location = new Point(22, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(191, 117);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2025_04_10_at_2_31_10_PM;
            pictureBox1.Location = new Point(15, 131);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1193, 647);
            Controls.Add(panel2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buscar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)presupuesto).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button cerrarSesion;
        private Panel panel1;
        private PictureBox buscar;
        private PictureBox pictureBox2;
        private Button huespedes;
        private Button ubicacion;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown presupuesto;
        private Label label1;
        private Button verReservas;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}