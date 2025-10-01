using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_Heranca
{
    public partial class FrmContaPoupanca : Form
    {
        public FrmContaPoupanca()
        {
            InitializeComponent();
        }

        ContaPoupanca objPoupanca = new ContaPoupanca();

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            objPoupanca.Titular = txtTitular.Text;
            objPoupanca.NumConta = double.Parse(txtNumConta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblValSaldo.Text = objPoupanca.VerificarSaldo().ToString();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            objPoupanca.Deposito(valor);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            objPoupanca.Saque(valor);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do Titular: " + objPoupanca.Titular + "\n Número da conta: " + objPoupanca.NumConta + "\n Data de Criação: " + objPoupanca.Abertura() + "\n Rendimento: " + objPoupanca.Rendimento());
        }
    }
}
