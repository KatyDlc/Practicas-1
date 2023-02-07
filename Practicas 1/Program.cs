using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 0- Realizar programa que despligue el factorial de numero
/* Esta exclamación quiere decir que hay que multiplicar todos los números enteros positivos
que hay entre ese número y el 1. */

namespace Practicas_1
{
    internal class Program0
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
