using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valorIva = 0.12;
            const double TOTALIVA = 100;
            Console.WriteLine("Viva FCP!");
            Console.ReadKey();
            Console.WriteLine("Valor do Iva: " +valorIva+ " Total: " +(valorIva *= TOTALIVA));
            Console.ReadLine();
            Console.WriteLine("Valor do Iva agora é: " + valorIva);
            Console.ReadKey();
        }
    }
}
