using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaValores
{
    internal class TrocaNomes
    {
        public TrocaNomes() { }

        public void Troca(ref string name1, ref string name2)
        {
            string aux = name1;
            name1 = name2;
            name2 = aux;
        }
    }
}
