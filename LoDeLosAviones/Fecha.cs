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
            monthCalendar2.MinDate = DateTime.Today;
            monthCalendar1.MinDate = DateTime.Today;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
