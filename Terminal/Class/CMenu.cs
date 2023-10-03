using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Interface;

namespace Terminal.Class
{
    public class CMenu : IMenu
    {
        public void Opciones()
        {
            COperaciones ope = new COperaciones();
            CDatos datos = new CDatos();

            double Saldo = 100000;
            double Luz = 15000;
            double Gas = 7500;
            double Agua = 3100;
            int opcion;

            Console.WriteLine("Bienvenido a la terminal del banco : " + datos.name);
            Console.WriteLine("");
            Console.WriteLine("Fehca actual: " + DateTime.Now);
            Console.WriteLine("");

            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Este es tu saldo disponible: $" + Saldo);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Que operacion desea realizar");
                Console.WriteLine("1. Extraer");
                Console.WriteLine("2. Despositar");
                Console.WriteLine("3. Pagar un servicio");
                Console.WriteLine("4. Salir");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Que operacion desaea realizar: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Saldo -= ope.Extraer(Saldo);
                        break;
                    case 2:
                        Saldo += ope.Depositar();
                        break;
                    case 3:
                        Saldo -= ope.Pagar(Saldo, Luz, Agua, Gas);
                        break;
                    case 4:
                        Console.Clear();
                        ope.Resumen(Saldo);
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Se ha equivocado de opcion, solo acepta opciones del 1 al 4");
                        break;
                }
            } while (opcion != 4);
        }
    }
}
