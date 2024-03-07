using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaNomes
{
    internal class Contador
    {
        public int ContaIniciais(string nome, int conta) {
            if (nome[0] == 'A' || nome[0] == 'B' || nome[0] == 'C')
            {
                conta += 1;
                return conta;
            }
            return conta;
                
        }
        
    }
}
