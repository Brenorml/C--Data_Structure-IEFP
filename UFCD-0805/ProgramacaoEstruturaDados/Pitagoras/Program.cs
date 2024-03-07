using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double catetoA, catetoO, hipotenusa;

            Console.Write("Indique a medida do cateto oposto: ");
            catetoA = double.Parse(Console.ReadLine());

            Console.Write("Indique a medida do cateto adjacente: ");
            catetoO = double.Parse(Console.ReadLine());

            hipotenusa = (Math.Pow(catetoA, 2)) + (Math.Pow(catetoO, 2));

            hipotenusa = Math.Sqrt(hipotenusa);

            Console.WriteLine("O valor da hipotenusa é: " + hipotenusa.ToString("0.00"));
            Console.ReadKey();
        }
    }
}
