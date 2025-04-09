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
    public partial class RegistrarseForm : Form
    {
        public RegistrarseForm()
        {
            InitializeComponent();
        }

        private void RegistrarseForm_Load(object sender, EventArgs e)
        {

        }

        private void volver_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Close();
        }

        private void crear_Click(object sender, EventArgs e)
        {
            if (password.Text != confirmar.Text)
            {
                MessageBox.Show("Confirme que las contrase;as sean iguales");
                return;
            }

            List<Usuario> users = XMLMan.CargarObjetos<Usuario>(Files.usuarios);

            foreach (Usuario usuario in users)
            {
                if (usuario.obtenerNombre() == nombre.Text)
                {
                    MessageBox.Show("Este usuario ya existe");
                    return;
                }
            }

            Usuario user = new Usuario(nombre.Text, password.Text, Usuario.id);
            XMLMan.GuardarObjeto(user, Files.usuarios);
            user.aumentarId();

            MessageBox.Show("Se ha creado el usuario exitosamente");

            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
}
