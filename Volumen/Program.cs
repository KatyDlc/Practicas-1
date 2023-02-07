using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3- Realizar programa que calcule el volumen de las figuras geometricas cubo, esfera, cono y piramide */

namespace Volumen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor, valor2;
            int area;
            double radio;
            int numero;

            Console.WriteLine(" ********** PROGRAMA QUE CALCULA EL VOLUMEN DE LAS ESFERAS **********  ");

            Console.WriteLine("\nQue figura desea calcular: ");

            Console.WriteLine("1. Cubo");
            Console.WriteLine("2. Esfera");
            Console.WriteLine("3. Cono");
            Console.WriteLine("4. Piramide\n");

            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nDigite el valor del area, el radio o la base: ");
            valor = Convert.ToInt32(Console.ReadLine());    


            switch (numero)
            {
                case 1:
                    area = valor * valor * valor;
                    Console.WriteLine("\nEl volumen del cubo es de: " + area);
                    break;
                case 2:
                    radio = ( 4.0 / 3.0) * Math.PI * Math.Pow (valor,3) ;
                    Console.WriteLine("\nEl volumen de la esfera es de: " + radio);
                    break;
                case 3:
                    Console.WriteLine("Digite la altura: ");
                    valor2= Convert.ToInt32(Console.ReadLine());
                    radio = (Math.PI * valor * valor * valor2) / 3;
                    Console.WriteLine("\nEl volumen del cono es de: " + radio);
                    break;
                case 4:
                    Console.WriteLine("Digite la altura: ");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    radio = (valor * valor) * valor2 * 1/3;
                    Console.WriteLine("\nEl volumen de la piramide es de: " + radio);
                    break;

            }
            
            Console.ReadLine(); 

        }
    }
}
