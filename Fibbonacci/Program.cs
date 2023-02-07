using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibbonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero, a = 0, b = 1, c;
            Console.WriteLine("Limite del fibbonaci: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= numero; i++)
            {
                if (i <= 1)
                {
                    c = i;
                }

                else
                {
                    c = a + b;
                    a = b;
                    b = c;
                }

                Console.WriteLine(c);
            }

            Console.ReadLine(); 
        }
    }
}
