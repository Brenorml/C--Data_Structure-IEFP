using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squarable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1, num2;
            Console.Write("Valor 1: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("A media geral é: " + (num1 + num2) / 2);
            Console.ReadLine();
            Console.WriteLine("Resultado da raiz quadrada: " + Math.Sqrt(num2));
            Console.ReadLine();
        }
    }
}
