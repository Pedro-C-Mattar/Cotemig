using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe
{
    internal class operacaobancaria
    {
        public int MostrarMaior(int n1, int n2)
        {
            if(n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        public double MostrarSoma(double n3)
        {
            return (n3 * 0.5) + n3;
        }
    }
}
