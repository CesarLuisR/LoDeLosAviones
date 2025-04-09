using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLosAviones
{
    public partial class Fecha : Form
    {
        public Fecha()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Fecha_Load(object sender, EventArgs e)
        {
            fechaF.MinDate = DateTime.Today;
            fechaI.MinDate = DateTime.Today;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void Listo_Click(object sender, EventArgs e)
        {
            Filtros.FechaInicio = fechaI.ToString();
            Filtros.FechaFinal = fechaF.ToString();
        }
    }
}
