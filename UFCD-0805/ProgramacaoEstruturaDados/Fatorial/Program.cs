using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num, fatorial = 1;

            //Fatorial com DO...WHILE
            Console.Write("Insira o número: ");
            num = long.Parse(Console.ReadLine());

            do
            {
                fatorial *= num;
                num--;
            } while (num > 1);                
            
            Console.WriteLine("Numero: " + num);
            Console.WriteLine("Fatorial: " + fatorial);
            Console.ReadKey();
            
            //Fatorial com FOR
            Console.Write("\nInsira o número: ");
            num = long.Parse(Console.ReadLine());
            
            for(fatorial = 1; num > 1; num--)
            {
                fatorial *= num;
            }

            Console.WriteLine("Numero: " + num);
            Console.WriteLine("Fatorial: " + fatorial);
            Console.ReadKey();
        }
    }
}
