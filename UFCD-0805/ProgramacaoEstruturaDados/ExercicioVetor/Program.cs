using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioVetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];
            int[] soma = new int[10];

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < vetor1.Length; j++)
                {
                    if(i == 0)
                    {
                        Console.Write("Indique um valor para o index [" + (j + 1) + "] do Vetor " + (i + 1) + ": ");
                        vetor1[j] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.Write("Indique um valor para o index [" + (j + 1) + "] do Vetor " + (i + 1) + ": ");
                        vetor2[j] = int.Parse(Console.ReadLine());
                    }
                    
                }
            }
            for(int i = 0; i < vetor1.Length; i++)
            {
                soma[i] = vetor1[i] + vetor2[i];
                Console.WriteLine("A soma dos vetores para o Vetor[" + (i + 1) + "]: " + soma[i]);
            }
            Console.ReadKey();
        }
    }
}
