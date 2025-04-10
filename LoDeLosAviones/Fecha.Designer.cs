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
            SuspendLayout();
            // 
            // fechaI
            // 
            fechaI.Location = new Point(18, 134);
            fechaI.MinDate = new DateTime(2025, 4, 8, 23, 6, 31, 0);
            fechaI.Name = "fechaI";
            fechaI.TabIndex = 1;
            fechaI.DateChanged += monthCalendar1_DateChanged;
            // 
            // fechaF
            // 
            fechaF.Location = new Point(355, 134);
            fechaF.MinDate = new DateTime(2025, 4, 8, 0, 0, 0, 0);
            fechaF.Name = "fechaF";
            fechaF.TabIndex = 2;
            fechaF.DateChanged += monthCalendar2_DateChanged;
            // 
            // Listo
            // 
            Listo.Location = new Point(269, 462);
            Listo.Margin = new Padding(2);
            Listo.Name = "Listo";
            Listo.Size = new Size(131, 39);
            Listo.TabIndex = 3;
            Listo.Text = "Listo";
            Listo.UseVisualStyleBackColor = true;
            Listo.Click += Listo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 78);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 4;
            label1.Text = "fecha final de reserva ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 78);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 5;
            label2.Text = "fecha inicial de reserva ";
            // 
            // Fecha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 549);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Listo);
            Controls.Add(fechaF);
            Controls.Add(fechaI);
            Margin = new Padding(2);
            Name = "Fecha";
            Text = "Fecha";
            Load += Fecha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar fechaI;
        private MonthCalendar fechaF;
        private Button Listo;
        private Label label1;
        private Label label2;
    }
}