using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaizQuadrada
{
    internal class Program
    {
        static void Main(string[] args)
        {  
            Calculo novo = new Calculo();
            
            for(int i = 1; i <= 20; i++) {                
                Console.Write(novo.CalculoRaiz(i) + "; ");
            }
            Console.WriteLine("\n");
            for (int i = 25; i <= 50; i++)
            {
                Console.Write(novo.CalculoRaiz(i) + "; ");
            }
            Console.WriteLine("\n");
            for (int i = 100; i <= 200; i++)
            {
                Console.Write(novo.CalculoRaiz(i) + "; ");
            }
            Console.ReadKey();

        }
    }
}
