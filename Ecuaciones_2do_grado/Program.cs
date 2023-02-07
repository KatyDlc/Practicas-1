using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//8- Realizar programa que resuelva ecuaciones de segundo grado con la formula general.

namespace Ecuaciones_2do_grado
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************* Programa que calcula ecuacione de segundo grado segun su formula cuadratica *************");

            Console.WriteLine("\nIntroduzca coeficiente de su termino cuadratico: ");

            int tc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIntroduzca coeficiente termino lineal: ");

            int tl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIntroduzca termino independiente: ");

            int ti = Convert.ToInt32(Console.ReadLine());

            if (tc == 1)
            {
                if (tl < 0)
                {
                    Console.WriteLine("\nSu ecuacion es: x²" + tl + "x+" + ti);
                }
                else if (ti < 0)
                {
                    Console.WriteLine("\nSu ecuacion es: x²+" + tl + "x" + ti);
                }

                else
                {
                    Console.WriteLine("\nSu ecuacion es: x²+" + tl + "x+" + ti);
                }

            }
            else
            {
                if (tl < 0)
                {
                    Console.WriteLine("\nSu ecuacion es: " + tc + "x²" + tl + "x+" + ti);
                }
                else if (ti < 0)
                {
                    Console.WriteLine("\nSu ecuacion es: " + tc + "x²+" + tl + "x" + ti);
                }

                else
                {
                    Console.WriteLine("\nSu ecuacion es: " + tc + "x²+" + tl + "x+" + ti);
                }

            }
            double diferencia = Math.Round(Math.Sqrt(((tl * tl) + (-4 * tc * ti))));


            double primeraSolucion = ((tl * (-1)) + diferencia) / (2 * tc);
            double segundaSolucion = ((tl * (-1)) - diferencia) / (2 * tc);

            Console.WriteLine("\nSus soluciones son:");
            Console.WriteLine("x₁=" + primeraSolucion);
            Console.WriteLine("x₂=" + segundaSolucion);

            double primeraSolucionr = primeraSolucion * (-1);
            double segundaSolucionr = segundaSolucion * (-1);


            if (primeraSolucionr < 0 && segundaSolucionr < 0)
            {
                Console.WriteLine("\nLas soluciones de su ecuacion son: (x" + primeraSolucionr + "),(x" +
                    segundaSolucionr + ")");
            }
            else if (primeraSolucionr < 0)
            {
                Console.WriteLine("\nLas soluciones de su ecuacion son: (x" + primeraSolucionr + "),(x+" +
                segundaSolucionr + ")");
            }
            else if (segundaSolucionr < 0)
            {
                Console.WriteLine("\nLas soluciones de su ecuacion son: (x+" + primeraSolucionr + "),(x" +
                segundaSolucionr + ")");
            }
            else
            {
                Console.WriteLine("\nLas soluciones de su ecuacion son: (x+" + primeraSolucionr + "),(x+" +
                segundaSolucionr + ")");
            }

            Console.ReadLine();
        }
    }
}
