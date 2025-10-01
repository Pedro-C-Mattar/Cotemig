using System.Windows.Forms;

namespace POO_Heranca
{
    class ContaEspecial : ContaComum
    {
        private double limite;

        public double Limite { get => limite; set => limite = value; }

        public double AberturaEspecial()
        {
            return limite;
        }

        public double SaqueEspecial(double Valor)
        {
             return Saldo - Valor;
        }
    }
}
