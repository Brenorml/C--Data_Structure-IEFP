using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Media
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2;
            Console.Write("Valor 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Valor 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("A media geral é: " + (n1 + n2) / 2);
            Console.ReadLine();
        }
    }
}
