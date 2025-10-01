using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorTempo
{
    internal class Metodos
    {
        public double ConvertH (double h)
        {
            return h * 60 * 60;
        }
        public double ConvertM(double m)
        {
            return m * 60;
        }
    }
}
