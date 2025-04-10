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

                HotelInfo.Create("Villa Escondida", "Privacidad absoluta", "310", "Bávaro", "4", "https://ik.imagekit.io/tvlk/apr-asset/Ixf4aptF5N2Qdfmh4fGGYhTN274kJXuNMkUAzpL5HuD9jzSxIGG5kZNhhHY-p7nw/hotel/asset/67818132-0fe4a69965f0f6ce71e5e304d4c3b066.jpeg?_src=imagekit&tr=c-at_max,f-jpg,fo-auto,h-203,pr-true,q-80,w-300");
                HotelInfo.Create("Luna de Miel Resort", "Especial para parejas", "290", "Punta Cana", "2", "https://procolombia.co/sites/default/files/procolombia/news/images/hoteles-01.webp");
                HotelInfo.Create("Hotel Montaña Azul", "Vistas de montaña espectaculares", "160", "Jarabacoa", "3", "https://cdn.bestlocationhotels.com/wp-content/uploads/2016/02/Impressive-Punta-Cana-.jpg");
                HotelInfo.Create("Río Encantado", "Relájate junto al río", "120", "Bonao", "3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRzDqPeOg_p1_TSc0gVJmM0wKHs3eBMhbB-g&s");
                HotelInfo.Create("Vista Colonial", "Descubre la historia dominicana", "200", "Santo Domingo", "2", "https://www.realhotelsandresorts.com/wp-content/uploads/2024/08/fachada-principal-700x467.jpg");
                HotelInfo.Create("Bahía Dorada", "Playas doradas de arena fina", "250", "La Romana", "3", "https://arqa.com/wp-content/uploads/2024/07/sg2287_1166-digital-530x354.jpg");
                HotelInfo.Create("Refugio del Valle", "Paz y tranquilidad", "100", "Constanza", "2", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266405735.jpg?k=ee4ba126eb4ac9ff18316f85a22eb3dfa73f95f333b198f5271b00870c15c5c0&o=&hp=1");
                HotelInfo.Create("Hotel Caribeño", "Calidez del Caribe", "170", "Punta Cana", "2", "https://media.istockphoto.com/id/119926339/es/foto/piscina-del-complejo-tur%C3%ADstico.jpg?s=612x612&w=0&k=20&c=xL-i7eF0tFmfvjZbWkOSvJTH5pzMVKWPt1iCTfZGwnw=");
                HotelInfo.Create("Sol y Mar Resort", "Sol garantizado todo el año", "240", "Bávaro", "3", "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGhvdGVsfGVufDB8fDB8fHww");
                HotelInfo.Create("Hostal Buena Vista", "Económico y bien ubicado", "70", "Santiago", "1", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0b/55/a0/4a/pool.jpg?w=1200&h=-1&s=1");
                HotelInfo.Create("Casa Colonial", "Auténtica experiencia colonial", "180", "Santo Domingo", "2", "https://images.unsplash.com/photo-1566073771259-6a8506099945?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG90ZWx8ZW58MHx8MHx8fDA%3D");
                HotelInfo.Create("Hotel Brisas del Valle", "Vistas y naturaleza", "150", "Jarabacoa", "3", "https://images.unsplash.com/photo-1566073771259-6a8506099945?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG90ZWx8ZW58MHx8MHx8fDA%3D");
                HotelInfo.Create("Hotel Mar y Tierra", "Lo mejor de ambos mundos", "210", "La Romana", "3", "https://pix10.agoda.net/hotelImages/124/1246280/1246280_16061017110043391702.jpg?ca=6&ce=1&s=414x232");
                HotelInfo.Create("Villa Cristal", "Lujo y comodidad", "320", "Bávaro", "4", "https://ik.imagekit.io/tvlk/apr-asset/Ixf4aptF5N2Qdfmh4fGGYhTN274kJXuNMkUAzpL5HuD9jzSxIGG5kZNhhHY-p7nw/hotel/asset/67818132-0fe4a69965f0f6ce71e5e304d4c3b066.jpeg?_src=imagekit&tr=c-at_max,f-jpg,fo-auto,h-203,pr-true,q-80,w-300");
                HotelInfo.Create("Eco Hotel Cima", "Aventura ecológica", "130", "Constanza", "2", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266405735.jpg?k=ee4ba126eb4ac9ff18316f85a22eb3dfa73f95f333b198f5271b00870c15c5c0&o=&hp=1");
                HotelInfo.Create("Resort Isla Bonita", "Experiencia isleña única", "280", "Punta Cana", "3", "https://procolombia.co/sites/default/files/procolombia/news/images/hoteles-01.webp");
                HotelInfo.Create("Hotel Azul Marino", "Inspirado en el océano", "220", "La Romana", "2", "https://media.istockphoto.com/id/119926339/es/foto/piscina-del-complejo-tur%C3%ADstico.jpg?s=612x612&w=0&k=20&c=xL-i7eF0tFmfvjZbWkOSvJTH5pzMVKWPt1iCTfZGwnw=");
                HotelInfo.Create("Refugio de la Montaña", "Escapa del bullicio", "140", "Jarabacoa", "3", "https://static.hosteltur.com/app/public/uploads/img/articles/2019/11/11/L_135450_sbe.jpg");
                HotelInfo.Create("Vista del Mar", "Panorámica al mar", "230", "Bávaro", "2", "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGhvdGVsfGVufDB8fDB8fHww");
                HotelInfo.Create("Hotel Jardines Coloniales", "Patios coloniales", "190", "Santo Domingo", "2", "https://images.unsplash.com/photo-1566073771259-6a8506099945?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG90ZWx8ZW58MHx8MHx8fDA%3D");
                HotelInfo.Create("Hostal del Centro", "Cerca de todo", "80", "Santiago", "1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_ufHUNXdoiM4fV1rEsd-mQh5hFjuk4_0_-w&s");
                HotelInfo.Create("Bahía Serena", "Tranquilidad absoluta", "260", "La Romana", "3", "https://arqa.com/wp-content/uploads/2024/07/sg2287_1166-digital-530x354.jpg");
                HotelInfo.Create("Eco Refugio Natura", "Sostenibilidad garantizada", "120", "Constanza", "2", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266405735.jpg?k=ee4ba126eb4ac9ff18316f85a22eb3dfa73f95f333b198f5271b00870c15c5c0&o=&hp=1");
                HotelInfo.Create("Villa Tropical", "Ambiente cálido y acogedor", "310", "Bávaro", "4", "https://ik.imagekit.io/tvlk/apr-asset/Ixf4aptF5N2Qdfmh4fGGYhTN274kJXuNMkUAzpL5HuD9jzSxIGG5kZNhhHY-p7nw/hotel/asset/67818132-0fe4a69965f0f6ce71e5e304d4c3b066.jpeg?_src=imagekit&tr=c-at_max,f-jpg,fo-auto,h-203,pr-true,q-80,w-300");
                HotelInfo.Create("Hotel Sol Caribe", "Sol, arena y mar", "240", "Punta Cana", "3", "https://procolombia.co/sites/default/files/procolombia/news/images/hoteles-01.webp");
                HotelInfo.Create("Refugio Encantado", "Desconexión total", "130", "Barahona", "2", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRzDqPeOg_p1_TSc0gVJmM0wKHs3eBMhbB-g&s");
                HotelInfo.Create("Hotel Buenaventura", "Aventura y relax", "200", "San Cristóbal", "3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTODcQrLnnhM4fJUxZk_AWAqpLOlx8_Adx47Q&s");
                HotelInfo.Create("Villa Jardín Secreto", "Encanto natural", "320", "Jarabacoa", "4", "https://cdn.bestlocationhotels.com/wp-content/uploads/2016/02/Impressive-Punta-Cana-.jpg");

                HotelInfo.Create("Hotel Paraíso", "Frente a la playa con vista al mar", "150", "Punta Cana", "2", "https://digital.ihg.com/is/image/ihg/holiday-inn-santo-domingo-4026517891-4x3");
                HotelInfo.Create("Montaña Mágica", "Refugio acogedor en la montaña", "120", "Jarabacoa", "4", "https://assets.simpleviewinc.com/simpleview/image/upload/c_limit,w_1000/crm/miamifl/Colony-GMCBV_283DBD1C-497F-40E1-BFC4019833A6DF29_5335ec78-cde2-49ce-bf026a6a541e9137.jpg");
                HotelInfo.Create("Ciudad Colonial", "Hotel boutique en el centro histórico", "180", "Santo Domingo", "2", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/2c/32/df/2f/hyatt-ziva-cap-cana-aerial.jpg?w=900&h=500&s=1");
                HotelInfo.Create("Eco Lodge Verde", "Experiencia ecológica en la naturaleza", "100", "Constanza", "3", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/266405735.jpg?k=ee4ba126eb4ac9ff18316f85a22eb3dfa73f95f333b198f5271b00870c15c5c0&o=&hp=1");
                HotelInfo.Create("Resort Bahía Azul", "Resort todo incluido frente al mar", "250", "La Romana", "2", "https://pix10.agoda.net/hotelImages/124/1246280/1246280_16061017110043391702.jpg?ca=6&ce=1&s=414x232");
                HotelInfo.Create("Villa del Sol", "Villa privada con piscina", "300", "Bávaro", "6", "https://ik.imagekit.io/tvlk/apr-asset/Ixf4aptF5N2Qdfmh4fGGYhTN274kJXuNMkUAzpL5HuD9jzSxIGG5kZNhhHY-p7nw/hotel/asset/67818132-0fe4a69965f0f6ce71e5e304d4c3b066.jpeg?_src=imagekit&tr=c-at_max,f-jpg,fo-auto,h-203,pr-true,q-80,w-300");
                HotelInfo.Create("Refugio Tranquilo", "Lugar perfecto para desconectarse", "90", "Barahona", "2", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT_ufHUNXdoiM4fV1rEsd-mQh5hFjuk4_0_-w&s");
                HotelInfo.Create("Hotel Vista Lago", "Vistas impresionantes al lago", "130", "Bonao", "3", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRzDqPeOg_p1_TSc0gVJmM0wKHs3eBMhbB-g&s");
                HotelInfo.Create("Hostal Cultural", "Hospedaje económico con actividades culturales", "60", "Santiago", "1", "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0b/55/a0/4a/pool.jpg?w=1200&h=-1&s=1");
                HotelInfo.Create("Hotel Aventura", "Ideal para amantes de la aventura", "110", "San Cristóbal", "2", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTODcQrLnnhM4fJUxZk_AWAqpLOlx8_Adx47Q&s");

                HotelInfo.Create("Costa Caribe", "Relájate frente al Caribe", "200", "La Romana", "4", "https://media.istockphoto.com/id/119926339/es/foto/piscina-del-complejo-tur%C3%ADstico.jpg?s=612x612&w=0&k=20&c=xL-i7eF0tFmfvjZbWkOSvJTH5pzMVKWPt1iCTfZGwnw=");
                HotelInfo.Create("Hotel Brisa Marina", "Vistas al mar y brisa tropical", "220", "Punta Cana", "3", "https://procolombia.co/sites/default/files/procolombia/news/images/hoteles-01.webp");
                HotelInfo.Create("Refugio Alpino", "Rodeado de naturaleza", "140", "Constanza", "2", "https://static.hosteltur.com/app/public/uploads/img/articles/2019/11/11/L_135450_sbe.jpg");
                HotelInfo.Create("Hotel Colonial Deluxe", "Lujo en la zona colonial", "280", "Santo Domingo", "2", "https://www.realhotelsandresorts.com/wp-content/uploads/2024/08/fachada-principal-700x467.jpg");
                HotelInfo.Create("Villa Campestre", "Escapada rural con encanto", "90", "Jarabacoa", "4", "https://cdn.bestlocationhotels.com/wp-content/uploads/2016/02/Impressive-Punta-Cana-.jpg");
                HotelInfo.Create("Hotel Jardines", "Amplios jardines y naturaleza", "130", "Santiago", "3", "https://images.unsplash.com/photo-1566073771259-6a8506099945?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8OHx8aG90ZWx8ZW58MHx8MHx8fDA%3D");
                HotelInfo.Create("Sunset Resort", "Atardeceres inolvidables", "260", "Bávaro", "2", "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?fm=jpg&q=60&w=3000&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxzZWFyY2h8MTB8fGhvdGVsfGVufDB8fDB8fHww");
                HotelInfo.Create("Eco Paraíso", "Conéctate con la naturaleza", "110", "Constanza", "2", "https://i0.wp.com/foodandpleasure.com/wp-content/uploads/2020/10/65345792-h1-facb_angular_pool_view_300dpi.jpg?fit=2800%2C1867&ssl=1");
                HotelInfo.Create("Bahía Blanca", "Lujo frente al océano", "270", "La Romana", "3", "https://arqa.com/wp-content/uploads/2024/07/sg2287_1166-digital-530x354.jpg");
                HotelInfo.Create("Aventura Tropical", "Explora la selva caribeña", "150", "San Cristóbal", "2", "https://imgcap.capturetheatlas.com/wp-content/uploads/2023/10/Villas-Sol-Beach-Resort-otro-de-los-hoteles-todo-incluido-en-Costa-Rica-que-puedes-escoger.jpg");
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