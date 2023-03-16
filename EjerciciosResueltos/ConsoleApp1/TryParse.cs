using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class TryParse
    {
        static void Main(string[] args)
        {

            int numero;
            bool conversionCorrecta;

            Console.WriteLine("Introduce un numero");

            conversionCorrecta = int.TryParse(Console.ReadLine(), out numero);//Convierte en entero y lo guarda en numero

            if (conversionCorrecta)
            {
                Console.WriteLine("Has introducuido el " + numero);
            }
            else
            {
                Console.WriteLine("No has introducido un numero");
            }

            Console.ReadKey();

        }
    }
}
