using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string date;
            string[] dateSplit;
            int year, day, month, age;
            DateTime bornDay;
                                    
            Console.Write("Indique a data de nascimento (DD/MM/AAAA): ");
            date = Console.ReadLine();
            dateSplit = date.Split('/');

            day = int.Parse(dateSplit[0]);
            month = int.Parse(dateSplit[1]);
            year = int.Parse(dateSplit[2]);

            bornDay = new DateTime(year, month, day);
            age = (DateTime.Now.Year - year);

            Console.WriteLine("\nIdade: " + age);
            Console.WriteLine("Dia: " + bornDay.DayOfWeek);
            Console.ReadKey();
        }
    }
}
