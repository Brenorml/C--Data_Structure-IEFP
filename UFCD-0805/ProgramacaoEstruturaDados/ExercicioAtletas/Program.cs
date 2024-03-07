using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAtletas
{
    static class Constants
    {
        public const int MaxString = 10;
    }
    internal class Program
    {
        struct PersonalData
        {
            public int id;
            public string name;
            public string team;
            public string test;
        }
        static void Main(string[] args)
        {
            PersonalData[] dataList = new PersonalData[Constants.MaxString];

            //Prenchimento do vetor com os dados dos participantes informados pelo utilizador
            for(int i = 0; i < dataList.Length; i++)
            {
                dataList[i].id = i + 1;
                Console.Write($"Indique o nome do participante {i + 1}: ");
                dataList[i].name = Console.ReadLine();
                Console.Write($"Indique a equipa do participante {i + 1}: ");
                dataList[i].team = Console.ReadLine();
                Console.Write($"Indique a prova do participante {i + 1}: ");
                dataList[i].test = Console.ReadLine();
                Console.WriteLine();
            }

            for (int i = 0; i < dataList.Length; i++)
            {
                Console.WriteLine($"Dorsal: {dataList[i].id}");
                Console.WriteLine($"Nome: {dataList[i].name}");
                Console.WriteLine($"Equipa: {dataList[i].team}");                
                Console.WriteLine($"Prova: {dataList[i].test}\n");
            }
            Console.ReadKey();

        }
    }
}
