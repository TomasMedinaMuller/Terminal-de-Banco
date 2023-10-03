using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Terminal.Interface;

namespace Terminal.Class
{

    public class CLogin : ILogin
    {
        public void Login()
        {
            CDatos d = new CDatos();

            Console.WriteLine("Ingrese el nombre: ");
            d.name = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña: ");
            d.password = Console.ReadLine();
            Console.Clear();

            while ( d.name != "user" || d.password != "user")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Datos Incorrectos");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ingrese el nombre: ");
                d.name = Console.ReadLine();
                Console.WriteLine("Ingrese la contraseña: ");
                d.password = Console.ReadLine();
            }

        }

    }
}
