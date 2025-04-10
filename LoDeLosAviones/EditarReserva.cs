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
    public partial class EditarReserva : Form
    {
        HotelInfo currHotel = null;
        public EditarReserva(HotelInfo hotel)
        {
            InitializeComponent();
            List<HotelInfo> list = XMLMan.CargarObjetos<HotelInfo>(Files.hoteles);
            foreach (HotelInfo rhotel in list)
            {
                if (rhotel.name == hotel.name)
                {
                    currHotel = rhotel;
                    break;
                }
            }

            label1.Text = hotel.name;
            label2.Text = hotel.description;
            label3.Text = hotel.precio;
            label4.Text = hotel.ubicacion;
            label5.Text = hotel.huespedes;
            label10.Text = currHotel.huespedes;
            label11.Text = currHotel.precio;
            label13.Text = Filtros.dias.ToString();
        }

        private void EditarReserva_Load(object sender, EventArgs e)
        {

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
            XMLMan.EditarObjeto(Files.reservas, e => e.name == currHotel.name && LoggedUser.loggedUser.nombre == e.User, reserva);

            ReservasUsuario r = new ReservasUsuario();
            r.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fecha fecha = new Fecha();
            fecha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Huespe h = new Huespe();
            h.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XMLMan.EliminarObjeto<ReservaInfo>(Files.reservas, e => e.name == currHotel.name && LoggedUser.loggedUser.nombre == e.User);
            ReservasUsuario r = new ReservasUsuario();
            r.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
