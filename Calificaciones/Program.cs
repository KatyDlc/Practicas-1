using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Realizar un programa que calcule la calificacion promedio basado en un conjunto de calificaciones introducidas por teclado e
// indique el literal correspondiente.

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("********************** Progama que calcula promedios/calificaciones ********************** ");

            Console.WriteLine("\nIngresar su primera calificacion: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese su segunda calificacion: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese su nota final: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIngrese su nota practica: ");
            int practica = Convert.ToInt32(Console.ReadLine());


           int prop = (valor1 + valor2) / 2;
            int promedio = (prop + valor3 + practica) / 3;
            Console.WriteLine("\nSu nota promedio es de: " + promedio);

            if (promedio < 100 && promedio > 90)
            {
                Console.WriteLine("Su nota literal es A");
            }

            else if (promedio <= 89 && promedio > 80)
            {
                Console.WriteLine("Su nota literal es B");
            }

            else if (promedio <= 79 && promedio > 70)
            {
                Console.WriteLine("Su nota literal es C");
            }

            else if (promedio <= 69 && promedio > 0)
            {
                Console.WriteLine("Su nota literal es F");
            }

            Console.ReadLine(); 
        }


    }
}
