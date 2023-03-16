using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Conversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            string valor1=Console.ReadLine();//guarda srting
            Console.WriteLine("Introduce otro numero");
            string valor2 = Console.ReadLine();

            //Convert no controla errores
            //int op1 = Convert.ToInt32(valor1);
            //int op2 = Convert.ToInt32(valor2);
            int op1 = int.Parse(valor1);
            int op2 = int.Parse(valor2);

            int resultado = op1 + op2;
            Console.WriteLine("La suma de {0} y {1} es: {2}",op1,op2,resultado);
        }
    }
}
