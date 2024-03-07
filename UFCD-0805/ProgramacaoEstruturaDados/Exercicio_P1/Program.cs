using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double iva = 0.21;
            double valorSemIva;
            valorSemIva = 23.5;
            double resultado;
            resultado = iva * valorSemIva;
            Console.WriteLine("Valor com IVA: " + resultado);
            Console.ReadLine();
        }
    }
}
