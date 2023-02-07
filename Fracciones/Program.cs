using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fracciones
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("*************** Bienvenidos al programa que calcula de fracciones ***************\n");
            Console.WriteLine("Que operacion desea realizar:");
            Console.WriteLine("1-Suma");
            Console.WriteLine("2-Resta");
            Console.WriteLine("3-Multiplicacion");
            Console.WriteLine("4-Division\n");

            int i = Convert.ToInt32(Console.ReadLine());

            switch (i)
            {
                case 1:

                    Console.WriteLine("\nIngrese su primer numerador: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su primer denominador: ");
                    int dem1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("\nIngrese su segundo numerador: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su segundo denominador: ");
                    int dem2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num2 + "/" + dem2);

                    if (dem1 == dem2)
                    {
                        int numis = num1 + num2;

                        Console.WriteLine("\nLa suma de fracciones es: " + numis + "/" + dem1);
                    }
                    else
                    {
                        int numdif = ((num1 * dem2) + (num2 * dem1));
                        int demdif = dem1 * dem2;

                        Console.WriteLine("\nLa suma de fracciones es: " + numdif + "/" + demdif);
                    }

                    break;

                case 2:
                    Console.WriteLine("\nIngrese su primer numerador: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su primer denominador: ");
                    dem1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("\nIngrese su segundo numerador: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su segundo denominador: ");
                    dem2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num2 + "/" + dem2);

                    if (dem1 == dem2)
                    {
                        int numis = num1 - num2;

                        Console.WriteLine("\nLa resta de fracciones es: " + numis + "/" + dem1);
                    }
                    else
                    {
                        int numdif = ((num1 * dem2) - (num2 * dem1));
                        int demdif = dem1 * dem2;

                        Console.WriteLine("\nLa resta de fracciones es: " + numdif + "/" + demdif);
                    }
                    break;

                case 3:
                    Console.WriteLine("\nIngrese el primer numerador: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese el primer denominador: ");
                    dem1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("\nIngrese el segundo numerador: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese el segundo denominador: ");
                    dem2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num2 + "/" + dem2);

                    int numr = num1 * num2;
                    int demr = dem1 * dem2;
                    Console.WriteLine("\nLa multiplicacion de fracciones es: " + numr + "/" + demr);

                    break;

                case 4:
                    Console.WriteLine("\nIngrese su primer numerador: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su primer denominador: ");
                    dem1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("su fraccion es: " + num1 + "/" + dem1);

                    Console.WriteLine("\nIngrese su segundo numerador: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nIngrese su segundo denominador: ");
                    dem2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nSu fraccion es: " + num2 + "/" + dem2);

                    numr = num1 * dem2;
                    demr = num2 * dem1;
                    Console.WriteLine("\nLa division de fracciones es: " + numr + "/" + demr);

                    break;

                default:
                    Console.WriteLine("Opcion incorrecta");
                    break;
            }

            Console.ReadLine();
        }
    }
}
