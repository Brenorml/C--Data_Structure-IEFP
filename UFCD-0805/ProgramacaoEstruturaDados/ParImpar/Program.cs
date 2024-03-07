using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor;

            Console.Write("Digite um valor: ");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
                Console.WriteLine("\nÉ um número par!");
            else
                Console.WriteLine("\nÉ um número ímpar");

            Console.ReadLine();
        }
    }
}
