
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
}
