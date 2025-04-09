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
    }
}
