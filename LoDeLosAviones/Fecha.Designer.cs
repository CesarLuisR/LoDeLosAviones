namespace LoDeLosAviones
{
    partial class Fecha
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
            fechaI = new MonthCalendar();
            fechaF = new MonthCalendar();
            Listo = new Button();
            label1 = new Label();
            label2 = new Label();
            dias = new NumericUpDown();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dias).BeginInit();
            SuspendLayout();
            // 
            // fechaI
            // 
            fechaI.Location = new Point(14, 107);
            fechaI.Margin = new Padding(7);
            fechaI.MinDate = new DateTime(2025, 4, 8, 23, 6, 31, 0);
            fechaI.Name = "fechaI";
            fechaI.TabIndex = 1;
            fechaI.DateChanged += monthCalendar1_DateChanged;
            // 
            // fechaF
            // 
            fechaF.Location = new Point(284, 107);
            fechaF.Margin = new Padding(7);
            fechaF.MinDate = new DateTime(2025, 4, 8, 0, 0, 0, 0);
            fechaF.Name = "fechaF";
            fechaF.TabIndex = 2;
            fechaF.DateChanged += monthCalendar2_DateChanged;
            // 
            // Listo
            // 
            Listo.Location = new Point(216, 386);
            Listo.Margin = new Padding(2);
            Listo.Name = "Listo";
            Listo.Size = new Size(105, 31);
            Listo.TabIndex = 3;
            Listo.Text = "Listo";
            Listo.UseVisualStyleBackColor = true;
            Listo.Click += Listo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 62);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 4;
            label1.Text = "fecha final de reserva ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 62);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 5;
            label2.Text = "fecha inicial de reserva ";
            // 
            // dias
            // 
            dias.Location = new Point(247, 337);
            dias.Name = "dias";
            dias.Size = new Size(150, 27);
            dias.TabIndex = 6;
            dias.ValueChanged += dias_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 339);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 7;
            label3.Text = "Dias";
            label3.Click += label3_Click;
            // 
            // Fecha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 439);
            Controls.Add(label3);
            Controls.Add(dias);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Listo);
            Controls.Add(fechaF);
            Controls.Add(fechaI);
            Margin = new Padding(2);
            Name = "Fecha";
            Text = "Fecha";
            Load += Fecha_Load;
            ((System.ComponentModel.ISupportInitialize)dias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar fechaI;
        private MonthCalendar fechaF;
        private Button Listo;
        private Label label1;
        private Label label2;
        private NumericUpDown dias;
        private Label label3;
    }
}