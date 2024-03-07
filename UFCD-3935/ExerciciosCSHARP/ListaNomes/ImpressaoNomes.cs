using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNomes
{
    internal class Impressao
    {
        public Impressao() { }

        public void ImpressaoNomes(String[] nome, int value) {
            for(int i = 0; i < value; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }
        
    }
}
