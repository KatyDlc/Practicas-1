using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Conversor de grados **********");

            Console.WriteLine("\nA que deseas convertir: ");

            Console.WriteLine("1. Celsius");
            Console.WriteLine("2. Kelvin");
            Console.WriteLine("3. Fahrenheit\n");

            double num = Convert.ToInt32(Console.ReadLine());
            Console.Clear();    

            switch(num)
            {
                case 1:
                    Console.WriteLine("\nIngrese el valor Celsius: ");
                    double Celsius = double.Parse(Console.ReadLine());

                    double kelvin = Celsius + 273.15;
                    double fahrenheit = (Celsius * 9 + (32 * 5)) / 5;

                    Console.WriteLine("\n" + Celsius + " grados celsius es igual a:\n " + kelvin + " grados Kelvin\n " + fahrenheit + " grados Fahrenheit");
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("\nIngrese el valor en Kelvin: ");
                    double k = double.Parse(Console.ReadLine());

                    double c = k - 273.15;
                    double f = (k -273.15) * 9/5 + 32;

                    Console.WriteLine("\n" + k + " grados kelvin es igual a:\n " + c + " grados Celsius\n " + f + " grados Fahrenheit");
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("\nIngrese el valor en Fahrenheit: ");
                    double GF = double.Parse(Console.ReadLine());

                    double GC = (GF - 32) * 5/9;
                    double GK = (GF - 32) * 5/9 + 273.15;

                    Console.WriteLine("\n" + GF + " grados Fahreheit es igual a:\n " + GC + " grados Celsius\n " + GK + " grados Fahrenheit");
                    Console.ReadLine();
                    break;

            }

           Console.ReadLine() ; 
            



        }
    }
}
