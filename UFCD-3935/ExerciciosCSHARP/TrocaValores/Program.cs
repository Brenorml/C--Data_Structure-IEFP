using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string X1, Y1;

            Console.Write("Digite o valor da primeira variável (X): ");
            X1 = Console.ReadLine();
            Console.Write("Digite o valor da primeira variável (Y): ");
            Y1 = Console.ReadLine();

            TrocaNomes novo = new TrocaNomes();

            novo.Troca(ref X1, ref Y1);
            Console.WriteLine("X = " + X1);
            Console.WriteLine("Y = " + Y1);
            Console.WriteLine("Pressione uma tecla para continuar...");
            Console.ReadKey();
        }
    }
}
