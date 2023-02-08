using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Bienvenido al programa de permutaciones ******************* ");

            List<string> objetos = new List<string>();

            Console.WriteLine("\nIntroduzca la cantidad de datos: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantidad; i++)
            {
                Console.WriteLine("\nIntroduzca el dato #" + i);
                string objeto = Console.ReadLine();

                objetos.Add(objeto);
            }
            int permutacion = 1;
            for (int i = 1; i <= objetos.Count; i++)
            {
                permutacion = permutacion * i;
            }

            Console.WriteLine("\nLa cantidad de permutaciones posible es: " + permutacion);

            Console.ReadKey();
        }
    }
}
