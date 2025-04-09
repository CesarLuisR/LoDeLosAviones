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

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
