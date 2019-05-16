using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_N4_Pag_74
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el valor A:");

            double c1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor B:");
            double c2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor C:");
            double c3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor D:");
            double c4 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el valor X:");
            double x= double.Parse(Console.ReadLine());

            Ecuacion_CEcuacion clase = new Ecuacion_CEcuacion(c1, c2, c3, c4);
            Console.WriteLine(clase.ValorPara(x));

            Console.ReadKey();
          }
    }
}
