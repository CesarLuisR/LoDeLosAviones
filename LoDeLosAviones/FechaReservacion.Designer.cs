namespace LoDeLosAviones
{
    partial class FechaReservacion
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
            label2 = new Label();
            label1 = new Label();
            fechaFinal = new MonthCalendar();
            fechaInicial = new MonthCalendar();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 57);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 20);
            label2.TabIndex = 9;
            label2.Text = "fecha inicial de reserva ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(421, 57);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 20);
            label1.TabIndex = 8;
            label1.Text = "fecha final de reserva ";
            // 
            // fechaFinal
            // 
            fechaFinal.Location = new Point(327, 102);
            fechaFinal.Margin = new Padding(7, 7, 7, 7);
            fechaFinal.MinDate = new DateTime(2025, 4, 8, 0, 0, 0, 0);
            fechaFinal.Name = "fechaFinal";
            fechaFinal.TabIndex = 7;
            // 
            // fechaInicial
            // 
            fechaInicial.Location = new Point(58, 102);
            fechaInicial.Margin = new Padding(7, 7, 7, 7);
            fechaInicial.MinDate = new DateTime(2025, 4, 8, 23, 6, 31, 0);
            fechaInicial.Name = "fechaInicial";
            fechaInicial.TabIndex = 6;
            // 
            // FechaReservacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(640, 360);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fechaFinal);
            Controls.Add(fechaInicial);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FechaReservacion";
            Text = "FechaReservacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private MonthCalendar fechaFinal;
        private MonthCalendar fechaInicial;
    }
}