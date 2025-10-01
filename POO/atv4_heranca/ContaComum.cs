using System;

namespace POO_Heranca
{
     class ContaComum
    {
        private double numConta;
        private double saldo;
        private string titular;
        private DateTime data;

        public double NumConta { get => numConta; set => numConta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Titular { get => titular; set => titular = value; }
        public DateTime Data { get => data; set => data = value; }

        public DateTime Abertura()
        {
            return Data;
        }

        public void Deposito(double Valor)
        {
            Saldo = Valor + Saldo;   
        }

        public void Saque(double Valor)
        {
            Saldo = Saldo - Valor;
        }

        public double VerificarSaldo()
        {
            return Saldo;
        }
    }
}
