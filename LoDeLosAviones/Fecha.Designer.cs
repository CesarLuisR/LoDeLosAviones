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
            monthCalendar1 = new MonthCalendar();
            monthCalendar2 = new MonthCalendar();
            Listo = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(18, 134);
            monthCalendar1.MinDate = new DateTime(2025, 4, 8, 23, 6, 31, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(355, 134);
            monthCalendar2.MinDate = new DateTime(2025, 4, 8, 0, 0, 0, 0);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 2;
            monthCalendar2.DateChanged += monthCalendar2_DateChanged;
            // 
            // Listo
            // 
            Listo.Location = new Point(269, 462);
            Listo.Name = "Listo";
            Listo.Size = new Size(131, 39);
            Listo.TabIndex = 3;
            Listo.Text = "Listo";
            Listo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(472, 78);
            label1.Name = "label1";
            label1.Size = new Size(183, 25);
            label1.TabIndex = 4;
            label1.Text = "fecha final de reserva ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 78);
            label2.Name = "label2";
            label2.Size = new Size(193, 25);
            label2.TabIndex = 5;
            label2.Text = "fecha inicial de reserva ";
            // 
            // Fecha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 549);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Listo);
            Controls.Add(monthCalendar2);
            Controls.Add(monthCalendar1);
            Name = "Fecha";
            Text = "Fecha";
            Load += Fecha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private MonthCalendar monthCalendar2;
        private Button Listo;
        private Label label1;
        private Label label2;
    }
}