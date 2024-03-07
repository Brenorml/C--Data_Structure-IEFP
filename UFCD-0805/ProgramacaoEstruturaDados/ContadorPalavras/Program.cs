using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorPalavras
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            string input;
            string[] words;
            int lengPhrase, count = 0;

            Console.Write("Digite uma frase: ");
            input = Console.ReadLine();
            words = input.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                count++;
            }

            Console.WriteLine("\nForam contabilizadas " + count + " palavras");
            Console.ReadKey();

            //Com split pelo professor

            if

            //Sem split pelo professor
            
            input = input.Trim();
            lengPhrase = input.Length;
            if(lengPhrase > 0)
            {
                count = 1;
                for (int i = 1; i <= lengPhrase; i++)
                {
                    if (input.Substring(i - 1, 1) == " ")
                    {
                        count++;
                    }
                }
            }
            else
            {
                count = 0;
            }
            
            Console.WriteLine("\nForam contabilizadas " + count + " palavras");
            Console.ReadKey();
        }
    }
}
