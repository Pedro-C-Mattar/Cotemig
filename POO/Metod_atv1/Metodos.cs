using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV1___metod
{
    internal class Metodos
    {
        public double Soma(double n1, double n2, double n3, double n4, double n5)
        {
            return n1 + n2 + n3 + n4 + n5;
        }

        public double Media(double n1, double n2, double n3, double n4, double n5)
        {
            return (n1 + n2 + n3 + n4 + n5) / 5;
        }

        public double Maior(double n1, double n2, double n3, double n4, double n5)
        {
            return Math.Max(n1,Math.Max(n2,Math.Max(n3,Math.Max(n4, n5))));
        }

        public double Menor(double n1, double n2, double n3, double n4, double n5)
        {
            return Math.Min(n1, Math.Min(n2, Math.Min(n3, Math.Min(n4, n5)))); ;
        }

        public double Potencia(double n2, double n3)
        {
            return Math.Pow(n2, n3);
        }
    }
}
