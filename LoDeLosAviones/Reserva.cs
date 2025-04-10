using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoDeLosAviones
{
    public partial class Reserva : Form
    {
        public Reserva()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {
            List<PaisTelefono> paises = new List<PaisTelefono>
            {
                new PaisTelefono { Nombre = "Afganistán", Codigo = "+93" },
                new PaisTelefono { Nombre = "Alemania", Codigo = "+49" },
                new PaisTelefono { Nombre = "Argentina", Codigo = "+54" },
                new PaisTelefono { Nombre = "Australia", Codigo = "+61" },
                new PaisTelefono { Nombre = "Brasil", Codigo = "+55" },
                new PaisTelefono { Nombre = "Canadá", Codigo = "+1" },
                new PaisTelefono { Nombre = "Chile", Codigo = "+56" },
                new PaisTelefono { Nombre = "China", Codigo = "+86" },
                new PaisTelefono { Nombre = "Colombia", Codigo = "+57" },
                new PaisTelefono { Nombre = "Corea del Sur", Codigo = "+82" },
                new PaisTelefono { Nombre = "Costa Rica", Codigo = "+506" },
                new PaisTelefono { Nombre = "Cuba", Codigo = "+53" },
                new PaisTelefono { Nombre = "Dinamarca", Codigo = "+45" },
                new PaisTelefono { Nombre = "Ecuador", Codigo = "+593" },
                new PaisTelefono { Nombre = "Egipto", Codigo = "+20" },
                new PaisTelefono { Nombre = "El Salvador", Codigo = "+503" },
                new PaisTelefono { Nombre = "Emiratos Árabes Unidos", Codigo = "+971" },
                new PaisTelefono { Nombre = "España", Codigo = "+34" },
                new PaisTelefono { Nombre = "Estados Unidos", Codigo = "+1" },
                new PaisTelefono { Nombre = "Francia", Codigo = "+33" },
                new PaisTelefono { Nombre = "Guatemala", Codigo = "+502" },
                new PaisTelefono { Nombre = "Honduras", Codigo = "+504" },
                new PaisTelefono { Nombre = "India", Codigo = "+91" },
                new PaisTelefono { Nombre = "Italia", Codigo = "+39" },
                new PaisTelefono { Nombre = "Japón", Codigo = "+81" },
                new PaisTelefono { Nombre = "México", Codigo = "+52" },
                new PaisTelefono { Nombre = "Nicaragua", Codigo = "+505" },
                new PaisTelefono { Nombre = "Panamá", Codigo = "+507" },
                new PaisTelefono { Nombre = "Paraguay", Codigo = "+595" },
                new PaisTelefono { Nombre = "Perú", Codigo = "+51" },
                new PaisTelefono { Nombre = "Portugal", Codigo = "+351" },
                new PaisTelefono { Nombre = "Reino Unido", Codigo = "+44" },
                new PaisTelefono { Nombre = "República Dominicana", Codigo = "+1" },
                new PaisTelefono { Nombre = "Rusia", Codigo = "+7" },
                new PaisTelefono { Nombre = "Uruguay", Codigo = "+598" },
                new PaisTelefono { Nombre = "Venezuela", Codigo = "+58" }

            };
        }

        private void comboBoxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paisSeleccionado = (PaisTelefono)comboBoxCodigo.SelectedItem;
            string codigo = paisSeleccionado.Codigo;
            comboBoxCodigo.DroppedDown = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
