using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************* Bienvenido al programa de combinaciones *******************");

            Console.WriteLine("\nIntroduzca la cantidad de objetos a combinar");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIntroduzca la cantidad de combinaciones que desea: ");
            int r = Convert.ToInt32(Console.ReadLine());

            List<string> lista = new List<string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("\nIngrese dato #: " + (i + 1));
                lista.Add(Console.ReadLine());
            }

            Console.WriteLine("\nCon repeticion o sin repeticion?");
            Console.WriteLine("\n1-) repeticion");
            Console.WriteLine("\n2-) sin repeticion");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    int num = (n + r - 1);
                    int nd = (n - 1);

                    int nff = 1;

                    for (int i = 1; i <= nd; i++)
                    {
                        nff = nff * i;
                    }

                    int numf = 1;
                    for (int i = 1; i <= num; i++)
                    {
                        numf = numf * i;
                    }

                    int rf = 1;
                    for (int i = 1; i <= r; i++)
                    {
                        rf = rf * i;
                    }
                    int dem = rf * nff;

                    int combinacion = numf / dem;
                    Console.WriteLine($"\nLa cantidad de combinaciones es {combinacion}");
                    break;


                case 2:

                    int nf = 1;
                    for (int i = 1; i <= n; i++)
                    {
                        nf = nf * i;
                    }


                    rf = 1;
                    for (int i = 1; i <= r; i++)
                    {
                        rf = rf * i;
                    }

                    int ndr = n - r;

                    int ndrf = 1;
                    for (int i = 1; i <= ndr; i++)
                    {
                        ndrf = ndrf * i;
                    }


                    dem = rf * ndrf;

                    combinacion = nf / dem;
                    Console.WriteLine($"\nLa cantidad de combinaciones es {combinacion}");
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
