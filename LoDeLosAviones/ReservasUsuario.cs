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
    public partial class ReservasUsuario : Form
    {
        public ReservasUsuario()
        {
            InitializeComponent();
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
            List<ReservaInfo> hotelInfos = XMLMan.CargarObjetos<ReservaInfo>(Files.reservas);

            // Recorrer cada hotel y crear los paneles con sus datos
            foreach (ReservaInfo hotel in hotelInfos)
            {
                HotelInfo hotelInfo = new HotelInfo(hotel.name, "", hotel.precio, hotel.ubicacion, hotel.huespedes, hotel.imagen);

                if (hotel.User != LoggedUser.loggedUser.nombre) continue;

                Panel panel1 = CrearPanelHotel(hotelInfo);
                panel1.Tag = hotelInfo;
                panel1.Click += Panel1_Click;

                // Cursor y borde para el panel
                panel1.Cursor = Cursors.Hand;
                panel1.MouseEnter += (s, e) => { panel1.BorderStyle = BorderStyle.FixedSingle; };
                panel1.MouseLeave += (s, e) => { panel1.BorderStyle = BorderStyle.None; };

                // Asignar eventos a todos los hijos del panel
                foreach (Control child in panel1.Controls)
                {
                    child.Click += Panel1_Click;
                    child.Cursor = Cursors.Hand;
                    child.MouseEnter += (s, e) => { panel1.BorderStyle = BorderStyle.FixedSingle; };
                    child.MouseLeave += (s, e) => { panel1.BorderStyle = BorderStyle.None; };

                    foreach (Control grandChild in child.Controls)
                    {
                        grandChild.Click += Panel1_Click;
                        grandChild.Cursor = Cursors.Hand;
                        grandChild.MouseEnter += (s, e) => { panel1.BorderStyle = BorderStyle.FixedSingle; };
                        grandChild.MouseLeave += (s, e) => { panel1.BorderStyle = BorderStyle.None; };

                        foreach (Control greatGrandChild in grandChild.Controls)
                        {
                            greatGrandChild.Click += Panel1_Click;
                            greatGrandChild.Cursor = Cursors.Hand;
                            greatGrandChild.MouseEnter += (s, e) => { panel1.BorderStyle = BorderStyle.FixedSingle; };
                            greatGrandChild.MouseLeave += (s, e) => { panel1.BorderStyle = BorderStyle.None; };
                        }
                    }
                }

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
            pictureBox1.ImageLocation = hotel.imagen;// Cambiar a la imagen correcta
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
        private void Panel1_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;

            // Buscar el panel contenedor
            Panel panel = null;

            while (control != null && panel == null)
            {
                panel = control as Panel;
                control = control.Parent;
            }

            if (panel != null)
            {
                HotelInfo hotel = panel.Tag as HotelInfo;

                if (hotel != null)
                {
                    EditarReserva r = new EditarReserva(hotel);
                    r.Show();
                    this.Close();
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReservasUsuario_Load(object sender, EventArgs e)
        {
            label2.Text = LoggedUser.loggedUser.nombre;
        }
    }
}
