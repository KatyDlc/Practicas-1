using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 14- Realizar programa que resuelva ecuaciones linea de primer grado.

namespace Ecuacion_Linear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Programa que calcula ecuaciones lineales del primer grado **********************");
            Console.WriteLine("Ingrese su primer valor: ");
            double valor1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su segundo valor: ");
            double valor2 = double.Parse(Console.ReadLine());

            if (valor1 != 0)
            {
                double x = -valor2 / valor1;
                Console.WriteLine("El valor de x es: " + x);
            }
          Console.ReadLine();   
        }
    }
}
