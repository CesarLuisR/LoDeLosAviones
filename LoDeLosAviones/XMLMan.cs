using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NominaForms
{
    internal class XMLMan
    {
        public static void GuardarObjeto<T>(T objeto, string rutaArchivo)
        {
            List<T> objetos = new List<T>();

            // Si el archivo existe, cargar datos existentes
            if (File.Exists(rutaArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    objetos = (List<T>)serializer.Deserialize(fs);
                }
            }

            // Añadir nuevo objeto
            objetos.Add(objeto);

            // Guardar lista actualizada
            XmlSerializer ser = new XmlSerializer(typeof(List<T>));
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                ser.Serialize(fs, objetos);
            }
        }

        // Versión genérica de CargarPersonas
        public static List<T> CargarObjetos<T>(string rutaArchivo)
        {
            List<T> objetos = new List<T>();

            if (File.Exists(rutaArchivo))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
                {
                    objetos = (List<T>)serializer.Deserialize(fs);
                }
            }

            return objetos;
        }

        public static void EliminarObjeto<T>(string rutaArchivo, Predicate<T> criterio)
        {
            if (!File.Exists(rutaArchivo))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            List<T> objetos;

            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
            {
                objetos = (List<T>)serializer.Deserialize(fs);
            }

            // Eliminar los que cumplen el criterio
            objetos.RemoveAll(criterio);

            // Guardar la lista actualizada
            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
            {
                serializer.Serialize(fs, objetos);
            }
        }

        public static void EditarObjeto<T>(string rutaArchivo, Predicate<T> criterio, T objetoEditado)
        {
            if (!File.Exists(rutaArchivo))
                return;

            XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
            List<T> objetos;

            using (FileStream fs = new FileStream(rutaArchivo, FileMode.Open))
            {
                objetos = (List<T>)serializer.Deserialize(fs);
            }

            // Encontrar el índice del objeto a editar
            int index = objetos.FindIndex(criterio);
            if (index != -1)
            {
                objetos[index] = objetoEditado;

                // Guardar la lista actualizada
                using (FileStream fs = new FileStream(rutaArchivo, FileMode.Create))
                {
                    serializer.Serialize(fs, objetos);
                }
            }
        }
    }
}
