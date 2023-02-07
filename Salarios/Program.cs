using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//13- Realizar programa que calcule el salario neto, basado en el salario bruto, realizando calculo de AFP y Seguro de Salud.
//El programa debe recibir cantidad de horas trabajadas las horas extras a partir de las 44 horas se pagada a 30% adiccional.

namespace Salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** Programa de calculo de salario **********************");

            Console.WriteLine("\nIntroduzca su salario sin descuentos: ");
            int salariob = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nIntroduzca sus horas trabajadas a la semana: ");
            int ht = Convert.ToInt32(Console.ReadLine());

            Console.Clear();    

            if (ht > 44)
            {
                int horasExtras = (ht - 44);
                int preciohorasestandar = (salariob / 44);
                int horasPorPagar = preciohorasestandar + (preciohorasestandar * (30 / 100));
                int salarioc = salariob + horasPorPagar;
                double afp = (salarioc * (0.15));
                double ss = (salarioc * (0.125));
                double salarioN = salarioc - afp - ss;

                Console.WriteLine($"\nEl empleado de sueldo: {salariob} y que trabajo: {ht} horas" +
                    $" obtuvo una compensacion de:{horasPorPagar} pesos por sus: {horasExtras} horas extras trabajadas" +
                    $" y un descuento calculado de: {afp} por su afp y {ss} por su seguro de salud" +
                    $" teniendo un salario neto de: {salarioN}"); 
            }
            else
            {
                double afp = (salariob * (0.15));
                double ss = (salariob * (0.125));
                double salarioN = salariob - afp - ss;
                Console.WriteLine($"\nEl empleado de: {salariob} de salario y que trabajo: {ht} horas" +
                    $" obtuvo un descuento calculado de: {afp} por su afp y: {ss} por su seguro " +
                    $"de salud teniendo un salario neto de: {salarioN}");
            }

            Console.ReadLine(); 
        }
    }
}
