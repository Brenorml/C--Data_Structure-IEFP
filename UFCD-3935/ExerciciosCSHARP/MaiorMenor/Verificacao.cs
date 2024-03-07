using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorMenor
{
    internal class Verificacao
    {
        public Verificacao() { }
        
        public static int Maiorde3(int x, int y, int z)
        {
            if (x < y)
                x = y;
            if (y < z)
                x = z;
            return x;
        }

        public static int Menorde3(int x, int y, int z)
        {
            if (x > y)
                x = y;
            if (y > z)
                x = z;
            return x;
        }
    }
}
