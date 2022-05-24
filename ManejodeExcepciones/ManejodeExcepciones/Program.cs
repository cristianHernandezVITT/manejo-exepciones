using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejodeExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables 
            int x = 0;
            double resultado = 0.0;
            //Excepción
            try
            {
                Console.Write("Indica un valor ");
                x = int.Parse(Console.ReadLine());
                resultado = Math.Pow(x, 2);
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            //Imprimir
            if(x!=0)
            {
                Console.WriteLine("El resultado de {0} elevado al cuadrado es {1}", x, resultado);
                Console.WriteLine("Presiona ENTER para salir");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Presiona ENTER para salir");
                Console.ReadLine();
            }
            
        }
    }
}
