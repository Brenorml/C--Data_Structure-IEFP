using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y, Z;

            Console.Write("Digite o primeiro valor: ");
            X = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            Z = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Maior: " + Verificacao.Maiorde3(X, Y, Z));
            Console.WriteLine("Menor: " + Verificacao.Menorde3(X, Y, Z));
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();


        }
    }
}
