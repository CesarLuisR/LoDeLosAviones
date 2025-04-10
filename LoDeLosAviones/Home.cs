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
            // Cargar los hoteles desde el archivo XML
            List<HotelInfo> hotelInfos = XMLMan.CargarObjetos<HotelInfo>(Files.hoteles);
            flowLayoutPanel1.Controls.Clear();

            bool notFound = true;

            // Recorrer cada hotel y crear los paneles con sus datos
            foreach (HotelInfo hotel in hotelInfos)
            {
                // Filtrar por ubicación, número de huéspedes y presupuesto
                if (hotel.ubicacion != Filtros.Ubicacio && Filtros.Ubicacio != null && Filtros.Ubicacio != "Ninguno") continue;
                if (int.Parse(hotel.huespedes) < Filtros.Huespedes && Filtros.Huespedes != 0) continue;
                if (Filtros.Presupuesto < int.Parse(hotel.precio) && Filtros.Presupuesto != 0) continue;

                notFound = false;

                Panel panel1 = CrearPanelHotel(hotel);
                panel1.Tag = hotel;
                panel1.Click += Panel1_Click;

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

            // Si no se encuentran resultados, mostrar el mensaje
            if (notFound)
            {
                // Asegurarse de que el FlowLayoutPanel esté configurado correctamente
                flowLayoutPanel1.AutoSize = false;  // Desactivar AutoSize
                flowLayoutPanel1.FlowDirection = FlowDirection.TopDown; // Asegura que los controles se alineen verticalmente
                flowLayoutPanel1.WrapContents = false; // Evita que los controles se envuelvan a una nueva línea

                // Crear el label de "No hay resultados"
                Label no = new Label();
                no.Text = "No hay resultados para la búsqueda";

                // Configurar el Label para que ocupe todo el espacio disponible
                no.TextAlign = ContentAlignment.MiddleCenter; // Centra el texto en el Label

                // Mejorar el aspecto del label
                no.Font = new Font("Arial", 14, FontStyle.Bold); // Establecer una fuente más grande y negrita
                no.ForeColor = Color.White; // Cambiar el color del texto
                no.BackColor = Color.Red; // Cambiar el color de fondo para hacerlo más visible
                no.Padding = new Padding(10); // Añadir un poco de espacio alrededor del texto
                no.Margin = new Padding(0, 10, 0, 10); // Añadir espacio adicional en la parte superior e inferior para un mejor margen

                // Establecer un tamaño fijo para el Label, para asegurarse de que sea visible
                no.Width = flowLayoutPanel1.ClientSize.Width - 20; // Ajusta el tamaño del Label al ancho del FlowLayoutPanel, dejando un margen
                no.Height = 50; // Ajusta una altura fija para el Label

                // Añadir el Label al FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(no);

                // Para evitar que el siguiente control se acomode junto a este Label, usar SetFlowBreak
                flowLayoutPanel1.SetFlowBreak(no, true);
            }
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
                panel1.Tag = hotel;
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

                Reserva r = new Reserva(hotel);
                r.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void presupuesto_Click(object sender, EventArgs e)
        {

        }

        private void presupuesto_ValueChanged(object sender, EventArgs e)
        {
            Filtros.Presupuesto = int.Parse(presupuesto.Value.ToString());
        }

        private void verReservas_Click(object sender, EventArgs e)
        {
            ReservasUsuario h = new ReservasUsuario();
            h.Show();
        }

        private void verReservas_Click_1(object sender, EventArgs e)
        {
            ReservasUsuario h = new ReservasUsuario();
            h.Show();
        }

        private void verReservas_Click_2(object sender, EventArgs e)
        {
            ReservasUsuario h = new ReservasUsuario();
            h.Show();
        }
    }
}
