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
            cerrarSesion = new Button();
            panel1 = new Panel();
            buscar = new PictureBox();
            panel5 = new Panel();
            label13 = new Label();
            panel4 = new Panel();
            label12 = new Label();
            panel3 = new Panel();
            label11 = new Label();
            pictureBox2 = new PictureBox();
            huespedes = new Button();
            ubicacion = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            presupuesto = new NumericUpDown();
            label1 = new Label();
            verReservas = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buscar).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)presupuesto).BeginInit();
            SuspendLayout();
            // 
            // cerrarSesion
            // 
            cerrarSesion.Location = new Point(1080, 24);
            cerrarSesion.Name = "cerrarSesion";
            cerrarSesion.Size = new Size(89, 29);
            cerrarSesion.TabIndex = 0;
            cerrarSesion.Text = "Cerrar sesion";
            cerrarSesion.UseVisualStyleBackColor = true;
            cerrarSesion.Click += cerrarSesion_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buscar);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(cerrarSesion);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1193, 94);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // buscar
            // 
            buscar.Image = Properties.Resources.pool;
            buscar.Location = new Point(947, 16);
            buscar.Name = "buscar";
            buscar.Size = new Size(114, 50);
            buscar.TabIndex = 12;
            buscar.TabStop = false;
            buscar.Click += pictureBox3_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(label13);
            panel5.Location = new Point(681, 16);
            panel5.Name = "panel5";
            panel5.Size = new Size(248, 59);
            panel5.TabIndex = 11;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(40, 8);
            label13.Name = "label13";
            label13.Size = new Size(75, 17);
            label13.TabIndex = 13;
            label13.Text = "Hubicacion";
            // 
            // panel4
            // 
            panel4.Controls.Add(label12);
            panel4.Location = new Point(411, 16);
            panel4.Name = "panel4";
            panel4.Size = new Size(248, 59);
            panel4.TabIndex = 11;
            panel4.Paint += panel4_Paint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(41, 6);
            label12.Name = "label12";
            label12.Size = new Size(52, 17);
            label12.TabIndex = 13;
            label12.Text = "Husper";
            // 
            // panel3
            // 
            panel3.Controls.Add(label11);
            panel3.Location = new Point(223, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(166, 59);
            panel3.TabIndex = 10;
            panel3.Paint += panel3_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(44, 7);
            label11.Name = "label11";
            label11.Size = new Size(43, 17);
            label11.TabIndex = 12;
            label11.Text = "Fecha";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.ChatGPT_Image_8_abr_2025__01_59_27_p_m_;
            pictureBox2.Location = new Point(23, 14);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // huespedes
            // 
            huespedes.Location = new Point(493, 114);
            huespedes.Name = "huespedes";
            huespedes.Size = new Size(248, 54);
            huespedes.TabIndex = 14;
            huespedes.Text = "huespedes";
            huespedes.UseVisualStyleBackColor = true;
            huespedes.Click += huespedes_Click;
            // 
            // ubicacion
            // 
            ubicacion.Location = new Point(764, 114);
            ubicacion.Name = "ubicacion";
            ubicacion.Size = new Size(248, 54);
            ubicacion.TabIndex = 15;
            ubicacion.Text = "ubicacion";
            ubicacion.UseVisualStyleBackColor = true;
            ubicacion.Click += ubicacion_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(87, 175);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1042, 357);
            flowLayoutPanel1.TabIndex = 16;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // presupuesto
            // 
            presupuesto.Location = new Point(295, 129);
            presupuesto.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            presupuesto.Name = "presupuesto";
            presupuesto.Size = new Size(111, 27);
            presupuesto.TabIndex = 17;
            presupuesto.ValueChanged += presupuesto_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 131);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 18;
            label1.Text = "presupuesto";
            // 
            // verReservas
            // 
            verReservas.Location = new Point(12, 122);
            verReservas.Name = "verReservas";
            verReservas.Size = new Size(146, 29);
            verReservas.TabIndex = 19;
            verReservas.Text = "Ver reservas";
            verReservas.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 647);
            Controls.Add(verReservas);
            Controls.Add(label1);
            Controls.Add(presupuesto);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(ubicacion);
            Controls.Add(huespedes);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buscar).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)presupuesto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cerrarSesion;
        private Panel panel1;
        private PictureBox buscar;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label13;
        private Label label12;
        private Label label11;
        private Button huespedes;
        private Button ubicacion;
        private FlowLayoutPanel flowLayoutPanel1;
        private NumericUpDown presupuesto;
        private Label label1;
        private Button verReservas;
    }
}