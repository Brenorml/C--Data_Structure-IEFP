using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ponto a = new Ponto();
            a.setX(1);
            a.setY(2);

            Ponto b = new Ponto(2, 5);
            //b.setX(3);
            Console.WriteLine("valor do x do ponto b: " + b.getX());
            Console.WriteLine("valor do y do ponto b: " + b.getY());

            double d1 = a.Distancia(b);
            double d2 = a.Distancia(2,5);

            Console.WriteLine("Distância d1: " + d1);
            Console.WriteLine("Distância d2: " + d2);

            a.setX(3000);
            double d3 = Ponto.Distancia(a, b);
            Console.WriteLine("Distância d3: " + d3);

            Ponto p = new Ponto(10.0, 0.0);
            double resultado = 0.0;
            p.DistanciaOrigem(ref resultado);
            Console.WriteLine("Resultado: " + resultado);


            Console.ReadKey();



        }
    }
}
