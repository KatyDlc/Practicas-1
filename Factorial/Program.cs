using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Por favor introduzca el numero que desea desplegar: ");
                int valor = Convert.ToInt32(Console.ReadLine());

                int factorial = 1;

                for (int i = 1; i <= valor; i++)
                {
                    factorial = factorial * i;
                }

                Console.WriteLine("El factorial de su numero es: " + factorial);
                Console.ReadLine();
        }
    }
}
