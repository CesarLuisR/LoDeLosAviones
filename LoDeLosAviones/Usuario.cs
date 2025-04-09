using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoDeLosAviones
{
    class LoggedUser
    {
        public static Usuario loggedUser = null;
    }

    [Serializable]
    public class Usuario
    {
        static public int id = 1;

        public string nombre;
        public string password;
        public bool logged = false;
        public int uId;

        public Usuario (string nombre, string password, int uId)
        {
            this.nombre = nombre;
            this.password = password;
            this.uId = uId;
        }
        public Usuario () { }

        public string obtenerNombre()
        {
            return nombre;
        }
        public string obtenerPassword()
        {
            return password;
        }
        public int obtenerId()
        {
            return uId;
        }
        public void aumentarId()
        {
            id++; 
        }
    }
}
