using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteClasse
{
    internal class Ponto
    {
        private double x;
        private double y;
        private double z;

        public Ponto() { }
        public Ponto (double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double getX() { return x; }
        public double getY() { return y; }
        public void setX(double x) { this.x = x;}
        public void setY(double y) {  this.y = y;}

        public double Distancia(Ponto p)
        {
            return Math.Sqrt((x - p.x) * (x - p.x) + (y - p.y) * (y - p.y));
        }

        public double Distancia(int x,  int y)
        {
            return Distancia(new Ponto(x, y));
        }

        public static double Distancia(Ponto p1, Ponto p2)
        {
            return p1.Distancia(p2);
        }

        public void DistanciaOrigem(ref double resultado)
        {
            resultado = Math.Sqrt(x * x + y * y);   
        }
    }
}
