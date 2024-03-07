using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string input;
            string[] value;

            Console.Write("Digite os valores a dividir (x,y): ");
            input = Console.ReadLine();
            value = input.Split(',');


            //validação de input
            if(value.Length == 2)
            {
                num1 = int.Parse(value[0]);
                num2 = int.Parse(value[1]);

                Console.Write("O resultado da divisão inteira é: " + (num1 / num2));
                
            }
            else
            {
                Console.WriteLine("Erro de expressão!!!");
            }
            Console.ReadKey();



        }
    }
}
