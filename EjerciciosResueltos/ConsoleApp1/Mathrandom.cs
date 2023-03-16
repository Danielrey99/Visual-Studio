using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades
{
    internal class Mathrandom
    {
        static void Main(string[] args) 
        {
            //Clave normal
            Random rnd= new Random();
            string clave = "";
            int longitud_clave = rnd.Next(6, 9);
            for (int i = 1; i <= longitud_clave; i++) 
            {
                clave = clave + (char)rnd.Next('A','Z'+1);//convertimos codigo ascii a char
            }
            Console.WriteLine("Clave: "+clave);

            //Clave Segura
            Random generador = new Random();
            string pass = "";
            //generamos letra mayus
            pass= ((char)generador.Next('A','Z'+1)).ToString();
            //digitos aleatorios
            int longitudNumeros = generador.Next(6, 9);
            for (int i =0; i< longitudNumeros; i++) 
            {
                pass = pass + generador.Next(0, 10);
            }
            //simbolo aleatorio
            pass = pass + (char)generador.Next('!','?'+1);

            Console.WriteLine("Clave Segura: " + pass);
            Console.ReadKey();

        }
    }
}
