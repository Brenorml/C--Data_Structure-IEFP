using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TesteVariaveisLocais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teste teste = new Teste();
            teste.F();
            Teste.G();


            Console.WriteLine(Matematica.Max(8, 2));

            Matematica Xpto = new Matematica();
            Console.WriteLine(Xpto.Soma(6,5));

            int[] vectorValores = { 1, 2, 3, 4, 58, 6, 7, 8, 9 };
            Console.WriteLine(Matematica.Max(vectorValores));

            Console.ReadKey();
        }

        class Teste
        {
            private int X;
            
            //Construtor
            public Teste()
            {
                X = 20;
            }

            public void F()
            {
                int X = 10;
                Console.WriteLine("Variável local: " + X);
                Console.WriteLine("Variável da Instâcia: " + this.X);
                
            }        
            
            public static void G()
            {
                
                Console.WriteLine("Este é um método Estático!");
                
            }
        }
    }
}
