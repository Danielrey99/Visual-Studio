using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class ReadLine
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
            Console.WriteLine("Escribe tu nombre");
            string nombre = Console.ReadLine();//Leer datos string
            Console.WriteLine("Escribe tu edad");
            int edad = Convert.ToInt32(Console.ReadLine());//convertir dato a int
            Console.WriteLine("Nombre: " + nombre + " Edad: " + edad);
            Console.ReadLine();

        }
    }
}
