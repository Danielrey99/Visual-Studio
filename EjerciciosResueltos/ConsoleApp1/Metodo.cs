namespace Actividades
{
    internal class Metodo
    {
        static void Main(string[] args)
        {
            //metodo suma
            int suma(int op1,int op2) 
            {
                int resultado;
                resultado = op1 + op2;
                return resultado;
            }
            //usamos el metodo
            int solucion = suma(5,5);
            Console.WriteLine("El resultado es: "+solucion);

            //metodo void
            void resta(int op1, int op2)
            {
                int resultado;
                resultado = op1 - op2;
                Console.WriteLine("El resultado es: {0}", resultado);
            }
            //usamos el metodo
            resta(5, 10);

        }
    }
}