using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3,3];
            int somaDiagonal, somaPar, somaImpar;
            somaDiagonal = somaPar = somaImpar = 0;

            //Ciclo para atribuir valores aos indexes da matriz bidimensional
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for(int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("Indique o valor[" + i + ", " + j + "]: ");
                    matriz[i,j] = int.Parse(Console.ReadLine());
                    if(i == j)
                    {
                        somaDiagonal += matriz[i, j];
                    }
                }                
            }
            Console.WriteLine();

            //Ciclo para a soma de valores pares e impares e impressão da matriz
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i,j] + "] ");
                    if (matriz[i,j] % 2 == 0)
                    {
                        somaPar += matriz[i, j];
                    }
                    else
                    {
                        somaImpar += matriz[i, j];
                    }
                }
                Console.WriteLine();
            }
            

            Console.WriteLine($"\nA soma dos valores da diagonal principal: {matriz[0,0]} + {matriz[1, 1]} + {matriz[2, 2]} = {somaDiagonal}");
            Console.WriteLine("A soma dos valores pares da matriz: " + somaPar);
            Console.WriteLine("A soma dos valores ímpares da matriz: " + somaImpar);
            Console.ReadKey();


        }
    }
}
