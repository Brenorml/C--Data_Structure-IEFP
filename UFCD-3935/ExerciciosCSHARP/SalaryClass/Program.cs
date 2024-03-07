using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryClass
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            float salario;

            Console.Write("Indique o salário: ");
            
            salario = float.Parse(Console.ReadLine());
            if (salario <= 0)
                Console.WriteLine("O salário tem que ser mair do que zero.");                
            else
                CalcularSalario(salario);

            Console.WriteLine("Pressione enter para continuar...");
            Console.ReadKey();
        }

        static void CalcularSalario(float salario)
        {
            float irs, segSocial = 0.2F;

            if (salario < 500)
            {
                salario -= salario * segSocial;
                Console.WriteLine("Salário final: " + salario);
            }
            else if (salario < 1000)
            {
                irs = 0.12F;
                salario -= (salario * segSocial) + (salario * irs);
                Console.WriteLine("Salário final: " + salario);
            }
            else if (salario < 1500)
            {
                irs = 0.15F;
                salario -= (salario * segSocial) + (salario * irs);
                Console.WriteLine("Salário final: " + salario);
            }
            else
            {
                irs = 0.18F;
                salario -= (salario * segSocial) + (salario * irs);
                Console.WriteLine("Salário final: " + salario);
            }
        }
    }
}
