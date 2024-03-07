using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaNomes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Conta = 0;
            string Nome = "0";

            Contador novo = new Contador();

            while(Nome != "ZZZ")
            {
                Conta = novo.ContaIniciais(Nome, Conta);
                Console.Write("Digite um nome ou ZZZ para terminar: ");
                Nome = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("Há " +  Conta + " nome(s) começado(s) por A, B ou C");
            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();

        }
    }
}
