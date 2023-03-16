using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Promedio
    {
        static void Main(string[] args)
        {

            float num1, num2, num3, num4, num5, promedio = 0;
            bool conversionCorrecta1, conversionCorrecta2, conversionCorrecta3, conversionCorrecta4, conversionCorrecta5;
            Console.WriteLine("Introdue el num 1");
            conversionCorrecta1 = float.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Introdue el num 2");
            conversionCorrecta2 = float.TryParse(Console.ReadLine(), out num2);
            Console.WriteLine("Introdue el num 3");
            conversionCorrecta3 = float.TryParse(Console.ReadLine(), out num3);
            Console.WriteLine("Introdue el num 4");
            conversionCorrecta4 = float.TryParse(Console.ReadLine(), out num4);
            Console.WriteLine("Introdue el num 5");
            conversionCorrecta5 = float.TryParse(Console.ReadLine(), out num5);

            if (conversionCorrecta1 && conversionCorrecta2 && conversionCorrecta3 && conversionCorrecta4 && conversionCorrecta5)
            {
                promedio = (num1 + num2 + num3 + num4 + num5) / 5f;
                Console.WriteLine("Promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("Error");
            }

            Console.ReadKey();

        }
    }
}
