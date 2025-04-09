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