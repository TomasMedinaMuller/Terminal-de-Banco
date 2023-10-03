namespace Terminal.Class
{
    public class Contenedor
    {
        CLogin login = new CLogin();
        CMenu menu = new CMenu();

        public void Application()
        {
            login.Login();
            menu.Opciones();
        }
    }
}