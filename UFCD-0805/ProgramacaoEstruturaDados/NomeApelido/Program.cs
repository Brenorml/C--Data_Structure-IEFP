using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NomeApelido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            string[] words;
            

            Console.Write("Digite o nome completo: ");
            input = Console.ReadLine();
            words = input.Split(' ');
            
            Console.WriteLine("\nNome: " + words[0]);
            Console.WriteLine("Apelido: " + words[(words.Length) - 1]);
            Console.ReadKey();
        }
    }
}
