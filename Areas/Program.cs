using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 2- Realizar programa que calcule las areas de las figuras geometricas cuadrado, circulo, 
triangulo, pentagono, hexagono */

namespace Areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA;
            int ladoB;
            int ladoC;  
            int valor;
            int perimetro; 
            float area;

               Console.WriteLine(" ---------- Calcula el area de una figura geometrica ----------\n");

                Console.WriteLine("Eliga la figura que desea calcular:  \n");

                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Circulo");
                Console.WriteLine("3. Triangulo");
                Console.WriteLine("4. Pentagono");
                Console.WriteLine("5. Hexagono \n");

                valor = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDigite el valor de la base o el area: ");
                ladoA = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nDigite el segundo valor de la altura o el area: ");
                ladoB = Convert.ToInt32(Console.ReadLine());


                switch (valor)
                {
                    case 1:
                        Console.WriteLine("\n ********** Ha seleccionado calcular el area de un CUADRADO ********** ");
                        ladoC = ladoA * ladoB;
                        Console.WriteLine("\n el area del cuadrado es: " + ladoC);
                        break;
                    case 2:
                        Console.WriteLine("\n ********** Ha seleccionado calcular el area de un CIRCULO ********** ");
                        area = (float)(ladoA * ladoB * 3.14);
                        Console.WriteLine("\n el area del circulo es: " + area);
                        break;
                    case 3:
                        Console.WriteLine("\n ********** Ha seleccionado calcular el area de un Triangulo ********** ");
                        ladoC = ladoA * ladoB / 2;
                        Console.WriteLine("\n el area del triangulo es :" + ladoC);
                        break;
                    case 4:
                        Console.WriteLine("\n ********** Ha seleccionado calcular el area de un PENTAGONO ********** ");
                        perimetro = ladoA * 5;
                        ladoC = perimetro * ladoB / 2;
                        Console.WriteLine("\n el area del pentagono es :" + ladoC);
                        break;
                    case 5:
                        Console.WriteLine("\n ********** Ha seleccionado calcular el area de un HEXAGONO ********** ");
                        perimetro = ladoA * 6;
                        ladoC = perimetro * ladoB / 2;
                        Console.WriteLine("\n el area del hexagono es :" + ladoC);
                        break;
                    
                }

            Console.ReadLine(); 

        }
    }
}
