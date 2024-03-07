using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float length, height, area;

            Console.Write("Indique o comprimento: ");
            length = float.Parse(Console.ReadLine());

            Console.Write("Indique a altura: ");
            height = float.Parse(Console.ReadLine());

            area = length * height;

            if(length == height)
            {
                Console.WriteLine("\nA área do quadrado é: " + area);                
            }
            else
            {
                Console.WriteLine("\nA área do rectângulo é: " + area);
            }
            Console.ReadLine();

        }
    }
}
