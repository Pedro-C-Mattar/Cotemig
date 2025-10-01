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
    public partial class FrmContaComum : Form
    {
        public FrmContaComum()
        {
            InitializeComponent();
        }

        ContaComum objConta = new ContaComum();

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            objConta.Deposito(valor);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            objConta.Saque(valor);
        }

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            objConta.Titular = txtTitular.Text;
            objConta.NumConta = double.Parse(txtNumConta.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblValSaldo.Text = objConta.VerificarSaldo().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do Titular: " + objConta.Titular + "\n Número da conta: " + objConta.NumConta + "\n Data de Criação: " + objConta.Abertura());
        }
    }
}
