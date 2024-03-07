using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Area
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

            area = CalcularArea(length, height);

            if (length == height)
            {
                Console.WriteLine("\nA área do quadrado é: " + area);
            }
            else
            {
                Console.WriteLine("\nA área do rectângulo é: " + area);
            }
            Console.ReadLine();

            
        }
        static float CalcularArea(float valueL, float valueH)
        {
            return valueL * valueH;
        }
    }
    
}
