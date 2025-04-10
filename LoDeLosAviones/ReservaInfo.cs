using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLosAviones
{
    [Serializable]
    public class ReservaInfo
    {
        public string User;
        public string name;
        public string ubicacion;
        public string fechaInicio;
        public string fechaFin;
        public string huespedes;
        public string precio;

        public ReservaInfo(string user, string name, string ubicacion, string fechaInicio, string fechaFin, string huespedes, string precio)
        {
            User = user;
            this.name = name;
            this.ubicacion = ubicacion;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
            this.huespedes = huespedes;
            this.precio = precio;
        }

        public ReservaInfo() { }
    }
}
