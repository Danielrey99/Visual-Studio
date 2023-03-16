using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Arrays
    {
        static void Main(string[] args)
        {


            int[] numeros = new int[10];
            bool convesionCorrecta = false;

            Console.WriteLine("Escribe 10 numeros");
            //LLenamos array
            for (int i=0; i < 10; i++) 
            {
                int numeroPantalla;
                convesionCorrecta = int.TryParse(Console.ReadLine(), out numeroPantalla);
                if (convesionCorrecta)
                {
                    numeros[i] = numeroPantalla;
                }
                else 
                {
                    Console.WriteLine("Error, no es un numero");
                }
            }

            if (convesionCorrecta) 
            {
                foreach(int numero in numeros) 
                {
                    for (int i=1;i<=10;i++) 
                    {
                        int resultado;
                        resultado = numero * i;
                        Console.WriteLine("{0} x {1} = {2}",numero,i,resultado);
                    }
                }
            }


        }
    }
}
