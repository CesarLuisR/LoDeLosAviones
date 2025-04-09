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

            comboBox1.DataSource = ubicaciones;
            comboBox1.DroppedDown = true;
        }
    }
}
