using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLosAviones
{
    [Serializable]
    public class HotelInfo
    {
        public string name;
        public string description;
        public string precio;
        public string ubicacion;
        public string huespedes;
        public string imagen;

        public HotelInfo(string name, string description, string precio, string ubicacion, string huespedes, string imagen)
        {
            this.name = name;
            this.description = description;
            this.precio = precio;
            this.ubicacion = ubicacion;
            this.huespedes = huespedes;
            this.imagen = imagen;
        }

        static public void Create(string name, string description, string precio, string ubicacion, string huespedes, string imagen)
        {
            HotelInfo info = new HotelInfo(name, description, precio, ubicacion, huespedes, imagen);
            XMLMan.GuardarObjeto(info, Files.hoteles);
        }

        public HotelInfo() { }
    }
}
