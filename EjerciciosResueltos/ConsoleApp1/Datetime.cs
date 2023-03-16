using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Datetime
    {

        static void Main(string[] args) 
        {

            //Escribir una fecha
            DateTime unafecha = new DateTime(1900,1,1);
            Console.WriteLine("Fecha completa: "+unafecha);
            Console.WriteLine("Dia: " + unafecha.DayOfWeek);


            //formato español
            Console.WriteLine("Dia en español: "+unafecha.ToString("dddd"));

            //Cuantos dias faltan
            DateTime fecha = new DateTime(2150,1,20);
            TimeSpan diferencia = fecha -DateTime.Now;
            Console.WriteLine(diferencia.Days/365.25+" años");

            Console.ReadKey();

        }
    }
}
