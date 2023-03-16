using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Condicionales
    {
        static void Main(string[] args) 
        {

            //switch
            string diasemna = 1;

            switch (diasemna) 
            {
                case "Lunes":
                {
                        Console.WriteLine("Dia 1");
                        break;
                }
                case "Martes":
                {
                        Console.WriteLine("Dia 1");
                        break;
                }
                default: 
                {
                        Console.WriteLine("ERROR");
                        break;
                }
            }


        }
    }
}
