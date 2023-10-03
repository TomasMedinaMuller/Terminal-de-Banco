using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Interface;

namespace Terminal.Class
{
    public class COperaciones : IOperaciones
    {
        CMenu menu = new CMenu();

        public double Depositar()
        {
            double deposito;

            Console.WriteLine("DEPOSITO:");
            Console.WriteLine("Cual es monto que desear despositar: ");
            deposito = int.Parse(Console.ReadLine());

            while (deposito <= 0)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El valor ingresado no es valido, tiene que ser mayor que 0");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Cual es monto que desear extraer? ");
                deposito = int.Parse(Console.ReadLine());
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("La operacion fue realizada con exito.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presiona cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();

            return deposito;
        }

        public double Extraer(double Saldo)
        {
            double extraccion;

            Console.WriteLine("EXTRACCION");
            Console.WriteLine("Cual es el monto que desea extraer?");
            extraccion = double.Parse(Console.ReadLine());

            while (extraccion > Saldo)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("no tiene suficiente saldo");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("cual es monto que desear extraer? ");
                extraccion = double.Parse(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("la operacion fue realizada con exito.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("presiona cualquier tecla para volver al menu");
            Console.ReadKey();
            Console.Clear();

            return extraccion;
        }

        public double Pagar(double Saldo, double Gas, double Luz, double Agua)
        {
            int opcion1;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Que servicio deesea pagar?");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Luz");
                Console.WriteLine("2. Gas");
                Console.WriteLine("3. Agua");
                Console.WriteLine("4. Volver");
                Console.WriteLine("---------------------------");
                Console.WriteLine("Que operacion desaea realizar (Del 1 al 4 las opciones) : ");
                opcion1 = int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcion1)
                {
                    case 1:
                        Saldo -= Luz;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Operacion realizada con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("El costo de la luz es de: $" + Luz);
                        Console.ReadKey();
                        Console.Clear();
                        return Luz;
                    case 2:
                        Saldo -= Gas;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Operacion realizada con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("El costo de la luz es de: $" + Gas);
                        Console.ReadKey();
                        Console.Clear();
                        return Gas;


                    case 3:
                        Saldo -= Agua;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Operacion realizada con exito");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("El costo de la luz es de: $" + Agua);
                        Console.ReadKey();
                        Console.Clear();
                        return Agua;

                    case 4:
                        menu.Opciones();
                        break;

                }

            } while (opcion1 <= 0 || opcion1 >= 5);

            return Saldo;
        }
        public void Resumen(double Saldo)
        {
          
            Console.WriteLine("Se Cerro la sesion, muchas gracias");
            Console.WriteLine(" ");
            Console.WriteLine("Estamido/a su resumen de cuenta es: ");
            Console.WriteLine("$ "+ Saldo +" en total");
            
        }
    }
}
