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

                HotelInfo.Create("Costa Caribe", "Rel�jate frente al Caribe", "200", "La Romana", "4", "costa_caribe.jpg");
                HotelInfo.Create("Hotel Brisa Marina", "Vistas al mar y brisa tropical", "220", "Punta Cana", "3", "brisa_marina.jpg");
                HotelInfo.Create("Refugio Alpino", "Rodeado de naturaleza", "140", "Constanza", "2", "refugio_alpino.jpg");
                HotelInfo.Create("Hotel Colonial Deluxe", "Lujo en la zona colonial", "280", "Santo Domingo", "2", "colonial_deluxe.jpg");
                HotelInfo.Create("Villa Campestre", "Escapada rural con encanto", "90", "Jarabacoa", "4", "villa_campestre.jpg");
                HotelInfo.Create("Hotel Jardines", "Amplios jardines y naturaleza", "130", "Santiago", "3", "hotel_jardines.jpg");
                HotelInfo.Create("Sunset Resort", "Atardeceres inolvidables", "260", "B�varo", "2", "sunset_resort.jpg");
                HotelInfo.Create("Eco Para�so", "Con�ctate con la naturaleza", "110", "Constanza", "2", "eco_paraiso.jpg");
                HotelInfo.Create("Bah�a Blanca", "Lujo frente al oc�ano", "270", "La Romana", "3", "bahia_blanca.jpg");
                HotelInfo.Create("Aventura Tropical", "Explora la selva caribe�a", "150", "San Crist�bal", "2", "aventura_tropical.jpg");

                HotelInfo.Create("Villa Escondida", "Privacidad absoluta", "310", "B�varo", "4", "villa_escondida.jpg");
                HotelInfo.Create("Luna de Miel Resort", "Especial para parejas", "290", "Punta Cana", "2", "luna_miel.jpg");
                HotelInfo.Create("Hotel Monta�a Azul", "Vistas de monta�a espectaculares", "160", "Jarabacoa", "3", "montana_azul.jpg");
                HotelInfo.Create("R�o Encantado", "Rel�jate junto al r�o", "120", "Bonao", "3", "rio_encantado.jpg");
                HotelInfo.Create("Vista Colonial", "Descubre la historia dominicana", "200", "Santo Domingo", "2", "vista_colonial.jpg");
                HotelInfo.Create("Bah�a Dorada", "Playas doradas de arena fina", "250", "La Romana", "3", "bahia_dorada.jpg");
                HotelInfo.Create("Refugio del Valle", "Paz y tranquilidad", "100", "Constanza", "2", "refugio_valle.jpg");
                HotelInfo.Create("Hotel Caribe�o", "Calidez del Caribe", "170", "Punta Cana", "2", "hotel_caribeno.jpg");
                HotelInfo.Create("Sol y Mar Resort", "Sol garantizado todo el a�o", "240", "B�varo", "3", "sol_y_mar.jpg");
                HotelInfo.Create("Hostal Buena Vista", "Econ�mico y bien ubicado", "70", "Santiago", "1", "hostal_buena_vista.jpg");

                HotelInfo.Create("Casa Colonial", "Aut�ntica experiencia colonial", "180", "Santo Domingo", "2", "casa_colonial.jpg");
                HotelInfo.Create("Hotel Brisas del Valle", "Vistas y naturaleza", "150", "Jarabacoa", "3", "brisas_valle.jpg");
                HotelInfo.Create("Hotel Mar y Tierra", "Lo mejor de ambos mundos", "210", "La Romana", "3", "mar_tierra.jpg");
                HotelInfo.Create("Villa Cristal", "Lujo y comodidad", "320", "B�varo", "4", "villa_cristal.jpg");
                HotelInfo.Create("Eco Hotel Cima", "Aventura ecol�gica", "130", "Constanza", "2", "eco_cima.jpg");
                HotelInfo.Create("Resort Isla Bonita", "Experiencia isle�a �nica", "280", "Punta Cana", "3", "isla_bonita.jpg");
                HotelInfo.Create("Hotel Azul Marino", "Inspirado en el oc�ano", "220", "La Romana", "2", "azul_marino.jpg");
                HotelInfo.Create("Refugio de la Monta�a", "Escapa del bullicio", "140", "Jarabacoa", "3", "refugio_montana.jpg");
                HotelInfo.Create("Vista del Mar", "Panor�mica al mar", "230", "B�varo", "2", "vista_mar.jpg");
                HotelInfo.Create("Hotel Jardines Coloniales", "Patios coloniales", "190", "Santo Domingo", "2", "jardines_coloniales.jpg");

                HotelInfo.Create("Hostal del Centro", "Cerca de todo", "80", "Santiago", "1", "hostal_centro.jpg");
                HotelInfo.Create("Bah�a Serena", "Tranquilidad absoluta", "260", "La Romana", "3", "bahia_serena.jpg");
                HotelInfo.Create("Eco Refugio Natura", "Sostenibilidad garantizada", "120", "Constanza", "2", "eco_natura.jpg");
                HotelInfo.Create("Villa Tropical", "Ambiente c�lido y acogedor", "310", "B�varo", "4", "villa_tropical.jpg");
                HotelInfo.Create("Hotel Sol Caribe", "Sol, arena y mar", "240", "Punta Cana", "3", "sol_caribe.jpg");
                HotelInfo.Create("Refugio Encantado", "Desconexi�n total", "130", "Barahona", "2", "refugio_encantado.jpg");
                HotelInfo.Create("Hotel Buenaventura", "Aventura y relax", "200", "San Crist�bal", "3", "buenaventura.jpg");
                HotelInfo.Create("Villa Jard�n Secreto", "Encanto natural", "320", "Jarabacoa", "4", "jardin_secreto.jpg");
                HotelInfo.Create("Casa del R�o", "Hospedaje junto al r�o", "140", "Bonao", "2", "casa_rio.jpg");
                HotelInfo.Create("Hostal Aventura Urbana", "Ideal para j�venes viajeros", "90", "Santo Domingo", "1", "aventura_urbana.jpg");
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