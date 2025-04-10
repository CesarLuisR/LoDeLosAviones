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
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(10, 10);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(458, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // listo
            // 
            listo.Location = new Point(182, 379);
            listo.Name = "listo";
            listo.Size = new Size(94, 29);
            listo.TabIndex = 1;
            listo.Text = "Listo";
            listo.UseVisualStyleBackColor = true;
            listo.Click += listo_Click;
            // 
            // Ubicacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 442);
            Controls.Add(listo);
            Controls.Add(comboBox1);
            Margin = new Padding(2);
            Name = "Ubicacion";
            Text = "Ubicacion";
            Load += Ubicacion_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private Button listo;
    }
}