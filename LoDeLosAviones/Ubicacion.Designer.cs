namespace LoDeLosAviones
{
    partial class Ubicacion
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
            comboBox1 = new ComboBox();
            listo = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(11, 22);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(368, 45);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listo
            // 
            listo.Location = new Point(397, 21);
            listo.Name = "listo";
            listo.Size = new Size(94, 29);
            listo.TabIndex = 1;
            listo.Text = "Listo";
            listo.UseVisualStyleBackColor = true;
            listo.Click += listo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ubicacion;
            pictureBox1.Location = new Point(105, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(274, 254);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Ubicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 442);
            Controls.Add(pictureBox1);
            Controls.Add(listo);
            Controls.Add(comboBox1);
            Margin = new Padding(2);
            Name = "Ubicacion";
            Text = "Ubicacion";
            Load += Ubicacion_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button listo;
        private PictureBox pictureBox1;
    }
}