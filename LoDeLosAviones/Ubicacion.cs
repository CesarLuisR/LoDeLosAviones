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
    public partial class Ubicacion : Form
    {
        public Ubicacion()
        {
            InitializeComponent();
        }

        private void Ubicacion_Load(object sender, EventArgs e)
        {
            List<HotelInfo> hoteles = XMLMan.CargarObjetos<HotelInfo>(Files.hoteles);
            List<string> ubicaciones = hoteles
            .Select(h => h.ubicacion)
            .Distinct()
            .ToList();
            ubicaciones.Add("Ninguno");

            comboBox1.DataSource = ubicaciones;
            comboBox1.DroppedDown = true;


            comboBox1.DataSource = ubicaciones;
            // A;adir la opcion de ninguno
            comboBox1.DroppedDown = true;

        }

        private void listo_Click(object sender, EventArgs e)
        {
            Filtros.Ubicacio = comboBox1.Text;
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
