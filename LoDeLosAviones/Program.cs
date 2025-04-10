namespace LoDeLosAviones
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            List<HotelInfo> hotelInfos = XMLMan.CargarObjetos<HotelInfo>(Files.hoteles);
            if (hotelInfos.Count == 0)
            {
            HotelInfo.Create("Hotel Para�so", "Frente a la playa con vista al mar", "150", "Punta Cana", "2", "paraiso.jpg");
            HotelInfo.Create("Monta�a M�gica", "Refugio acogedor en la monta�a", "120", "Jarabacoa", "4", "montana.jpg");
            HotelInfo.Create("Ciudad Colonial", "Hotel boutique en el centro hist�rico", "180", "Santo Domingo", "2", "colonial.jpg");
            HotelInfo.Create("Eco Lodge Verde", "Experiencia ecol�gica en la naturaleza", "100", "Constanza", "3", "eco_verde.jpg");
            HotelInfo.Create("Resort Bah�a Azul", "Resort todo incluido frente al mar", "250", "La Romana", "2", "bahia_azul.jpg");
            HotelInfo.Create("Villa del Sol", "Villa privada con piscina", "300", "B�varo", "6", "villa_sol.jpg");
            HotelInfo.Create("Refugio Tranquilo", "Lugar perfecto para desconectarse", "90", "Barahona", "2", "refugio.jpg");
            HotelInfo.Create("Hotel Vista Lago", "Vistas impresionantes al lago", "130", "Bonao", "3", "vista_lago.jpg");
            HotelInfo.Create("Hostal Cultural", "Hospedaje econ�mico con actividades culturales", "60", "Santiago", "1", "hostal.jpg");
            HotelInfo.Create("Hotel Aventura", "Ideal para amantes de la aventura", "110", "San Crist�bal", "2", "aventura.jpg");

            }

            List<Usuario> usuarios = XMLMan.CargarObjetos<Usuario>(Files.usuarios);
            bool found = false;
            foreach (Usuario user in usuarios)
            {
                if (user.logged == true)
                {
                    LoggedUser.loggedUser = user;
                    Application.Run(new Home());
                    found = true;
                    break;
                }
            }

            if (found == false)
            {
                Application.Run(new Login());
            }

            // Klk Alejandro
            // Otra cosa mas
            //Holaaaa
            // Dime a ver
            // ahasdlfa
            //tej7doilk
            //yrtuiop

            // Hola Estarlin
            // Hola
        }
    }
}