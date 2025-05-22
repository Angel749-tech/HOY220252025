using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_SEMANA_8
{
    class Program
    {
        double x, y;
        static void Main(string[] args)
        {
            int opcion;
            char continuar;




            do
            {
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("0. Salir");

                Console.WriteLine("\nIngrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (opcion < 0 || opcion >= 4);

            Console.WriteLine("Ingrese X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Y");
            int y = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0: Console.WriteLine("Cerrando..."); return;
                case 1:
                    break;
                    suma(x, y);
                case 2:
                    break;
                    resta(x, y);
                case 3:
                    break;
                    division(x, y);
                case 4:
                    break;
                    multiplicacion(x, y);
            }

            Console.WriteLine("\n¿Desea continuar? (S/N): ");

            Console.Clear();



        }



        static void suma(int x, int y)
        {
            Console.WriteLine("La suma es: " + (x + y));
        }

        static void resta(int x, int y)
        {
            Console.WriteLine("La resta es: " + (x - y));
        }


        static void division(int x, int y)
        {
            if (y != 0)
                Console.WriteLine("La división es: " + (x / y));
            else
                Console.WriteLine("No se puede dividir entre cero");
        }


        static void multiplicacion(int x, int y)
        {
            Console.WriteLine("La multiplicación es: " + (x * y));
        }
    }
}
