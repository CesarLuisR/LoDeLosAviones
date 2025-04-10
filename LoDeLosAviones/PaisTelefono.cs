using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoDeLosAviones
{
    public class PaisTelefono
    {
        public string Nombre;
        public string Codigo;

        public override string ToString()
        {
            return $"{Nombre} {Codigo}";
        }
    }
}
