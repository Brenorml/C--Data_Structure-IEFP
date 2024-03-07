using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] Nomes = { "Breno", "Patrícia", "Carla", "Felipe", "Ana", "Rosana", "Ruy" };

            int X = 4;

            Impressao novo = new Impressao();

            novo.ImpressaoNomes(Nomes, X);

            Console.WriteLine("Selecionamos os " + X + " primeiros nomes de uma lista de " + Nomes.Length);
            Console.ReadKey();
        }
    }
}
