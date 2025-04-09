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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = XMLMan.CargarObjetos<Usuario>(Files.usuarios);
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.logged == true)
                {
                    usuario.logged = false;
                    XMLMan.EditarObjeto(Files.usuarios, e => e.obtenerId() == usuario.obtenerId(), usuario);
                }
            }
            LoggedUser.loggedUser = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Close();
            login.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fecha_Click(object sender, EventArgs e)
        {
            Fecha f = new Fecha();
            f.Show();
        }

        private void huespedes_Click(object sender, EventArgs e)
        {
            Huespe h = new Huespe();
            h.Show();
        }

        private void ubicacion_Click(object sender, EventArgs e)
        {
            Ubicacion u = new Ubicacion();
            u.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Boton de buscar supongo

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool controlesCreados = false;

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            if (!controlesCreados)
            {
                CrearControlesDinamicamente();
                controlesCreados = true;
            }
        }

        private void CrearControlesDinamicamente()
        {
            // Cargar los objetos de los hoteles
            List<HotelInfo> hotelInfos = XMLMan.CargarObjetos<HotelInfo>(Files.hoteles);

            // Recorrer cada hotel y crear los paneles con sus datos
            foreach (HotelInfo hotel in hotelInfos)
            {
                Panel panel1 = CrearPanelHotel(hotel);

                // Asegurarse de que se agregue al FlowLayoutPanel en el hilo principal
                if (flowLayoutPanel1.InvokeRequired)
                {
                    flowLayoutPanel1.Invoke(new Action(() =>
                    {
                        flowLayoutPanel1.Controls.Add(panel1);
                    }));
                }
                else
                {
                    flowLayoutPanel1.Controls.Add(panel1);
                }
            }
        }

        private Panel CrearPanelHotel(HotelInfo hotel)
        {
            // Crear los controles dentro del panel para este hotel
            Label label1 = CrearLabel("inpuestos y cargos incluidos", new Point(665, 174), new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold));
            Label label2 = CrearLabel(hotel.precio, new Point(777, 146), new Font("Segoe UI", 13.8F, FontStyle.Bold));
            Label label3 = CrearLabel("$133 de dto.", new Point(720, 119), new Font("Segoe UI", 10.8F, FontStyle.Bold), Color.FromArgb(0, 192, 0));
            Label label4 = CrearLabel("Reserva ahora, paga después", new Point(271, 153), new Font("Segoe UI Light", 10.2F, FontStyle.Regular));
            Label label5 = CrearLabel("100% reembolsable", new Point(269, 131), new Font("Segoe UI Light", 10.2F, FontStyle.Regular));
            Label label6 = CrearLabel("Habitaciones elegantes, gastronomía y la mejor ubicación.", new Point(272, 101), new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold));
            Label label7 = CrearLabel(hotel.description, new Point(272, 84), new Font("Segoe UI Semibold", 7.8F, FontStyle.Bold));
            Label label8 = CrearLabel($"Descubre el corazón de {hotel.ubicacion}", new Point(271, 67), new Font("Segoe UI", 7.8F, FontStyle.Bold));
            Label label9 = CrearLabel(hotel.ubicacion, new Point(270, 34), new Font("Segoe UI Light", 10.2F, FontStyle.Regular));
            Label label10 = CrearLabel(hotel.name, new Point(266, 3), new Font("Segoe UI", 13.8F, FontStyle.Bold));

            PictureBox pictureBox1 = new PictureBox();
            pictureBox1.Image = Properties.Resources.ChatGPT_Image_8_abr_2025__01_59_27_p_m_;  // Cambiar a la imagen correcta
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            // Crear el panel y agregar los controles
            Panel panel1 = new Panel();
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(52, 35); // Ajusta la ubicación del panel
            panel1.Size = new Size(862, 198); // Ajusta el tamaño del panel

            return panel1;
        }

        private Label CrearLabel(string texto, Point ubicacion, Font fuente, Color? colorFondo = null)
        {
            Label label = new Label();
            label.AutoSize = true;
            label.Text = texto;
            label.Location = ubicacion;
            label.Font = fuente;
            if (colorFondo.HasValue)
            {
                label.BackColor = colorFondo.Value;
            }
            return label;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
