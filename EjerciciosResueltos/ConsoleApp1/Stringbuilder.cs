using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Stringbuilder
    {
        static void Main(string[] args)
        {

            char[] caracteres = new char[10];
            StringBuilder sb = new();

            //LLenamos array
            for (int i = 0; i < 10; i++)
            {
                caracteres[i] = (char)Console.Read();
            }

            foreach (char c in caracteres)
            {
                char caracterMayus;
                caracterMayus = char.ToUpper(c);
                sb.Append(caracterMayus);
            }

            Console.WriteLine("La cadena final es: " + sb.ToString());
            Console.ReadLine();

        }

    }
}
