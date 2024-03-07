using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int bruto; //bruto utilizado anteiormente para poder utilizar inteiro nas condicionais
            float salario, irs, segSocial = 0.2F;


            Console.Write("Indique o salário: ");
            //bruto = int.Parse(Console.ReadLine());
            //salario = (float)bruto; //necessário o casting pois estruturas de condição não trabalham com números reais
            
            salario = float.Parse(Console.ReadLine()); //Correção feita com o professor

            if (salario < 500)
            {
                salario -= salario * segSocial;
                Console.WriteLine("Salário final: " + salario);
            }            
            else if(salario < 1000)
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
            Console.ReadLine();
        }
    }
}
