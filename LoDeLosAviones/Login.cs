
using System.Drawing.Drawing2D;

namespace LoDeLosAviones
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        private async void MoverImagenSuavemente()
        {
            avion.BackColor = Color.Transparent;
            for (int i = 0; i < 20000; i++) // Cantidad de pasos que quieras
            {
                avion.BringToFront();
                if (i % 4 == 0)
                {
                    avion.Top -= 1;  // Mover hacia arriba a un ritmo menor
                    avion.Width = (int)(avion.Width * 0.99999999); // Reducir el tamaño en 1% en cada paso
                    avion.Height = (int)(avion.Height * 0.9999999); // Reducir el tamaño en 1% en cada paso
                }
                avion.Left += 3; // Aumentar la cantidad para mover más rápido a la derecha

                // Reducir el tamaño de la imagen de forma gradual

                await Task.Delay(50); // Esperar 10 milisegundos entre cada movimiento
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MoverImagenSuavemente();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void registrarse_Click(object sender, EventArgs e)
        {
            RegistrarseForm f = new RegistrarseForm();
            f.Show();
            this.Hide();
        }

        private void entrar_Click(object sender, EventArgs e)
        {
            List<Usuario> lista = XMLMan.CargarObjetos<Usuario>(Files.usuarios);

            bool found = false;
            foreach (Usuario usuario in lista)
            {
                if (Nombre.Text == usuario.obtenerNombre())
                {
                    found = true;
                    if (Contrasena.Text != usuario.obtenerPassword())
                    {

                        break;
                    }

                    usuario.logged = true;

                    XMLMan.EditarObjeto<Usuario>(Files.usuarios, e => e.obtenerId() == usuario.obtenerId(), usuario);

                    LoggedUser.loggedUser = usuario;
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                    break;
                }
            }

            if (!found)
                MessageBox.Show("No existe el usuario");
        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
