using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoDeLosAviones
{
    public partial class Huespe : Form
    {
        int adultCounter = 0;
        int childCounter = 0;
        public Huespe()
        {
            InitializeComponent();
            adultos.Text = adultCounter.ToString();
            Ninos.Text = childCounter.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adultCounter++;
            adultos.Text = adultCounter.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adultCounter == 0) return;
            adultCounter--;
            adultos.Text = adultCounter.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (childCounter == 0) return;
            childCounter--;
            Ninos.Text = childCounter.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            childCounter++;
            Ninos.Text = childCounter.ToString();
        }

        private void listo_Click(object sender, EventArgs e)
        {
            Filtros.Huespedes = adultCounter + childCounter;
            this.Close();
        }

        private void Huespe_Load(object sender, EventArgs e)
        {

        }
    }
}
