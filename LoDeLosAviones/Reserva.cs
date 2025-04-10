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
        HotelInfo currHotel = null;
        public Reserva(HotelInfo hotel)
        {
            InitializeComponent();
            label1.Text = hotel.name;
            label2.Text = hotel.description;
            label3.Text = hotel.precio;
            label4.Text = hotel.ubicacion;
            label5.Text = hotel.huespedes;
            currHotel = hotel;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Reserva_Load(object sender, EventArgs e)
        {


        }

        private void comboBoxCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Huespe h = new Huespe();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fecha fecha = new Fecha();
            fecha.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Filtros.Huespedes > int.Parse(currHotel.huespedes))
            {
                MessageBox.Show("El numero de huespedes excede el maximo permitible");
                return;
            }

            int precio = int.Parse(currHotel.precio) * Filtros.dias;

            ReservaInfo reserva = new ReservaInfo(LoggedUser.loggedUser.nombre, currHotel.name, currHotel.ubicacion, Filtros.FechaInicio, Filtros.FechaFinal, Filtros.Huespedes.ToString(), $"{precio}");
            XMLMan.GuardarObjeto(reserva, Files.reservas);
            this.Close();
        }
    }
}
