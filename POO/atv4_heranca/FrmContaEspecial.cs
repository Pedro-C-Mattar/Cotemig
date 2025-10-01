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
    public partial class FrmContaEspecial : Form
    {
        public FrmContaEspecial()
        {
            InitializeComponent();
        }

        ContaEspecial objEspecial = new ContaEspecial();

        private void btnAbertura_Click(object sender, EventArgs e)
        {
            objEspecial.Titular = txtTitular.Text;
            objEspecial.NumConta = double.Parse(txtNumConta.Text);
            objEspecial.Limite = double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblValSaldo.Text = objEspecial.VerificarSaldo().ToString();
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            objEspecial.Deposito(valor);
        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            double valor = double.Parse(txtValor.Text);
            if (valor > objEspecial.Limite)
            {
                MessageBox.Show("Excedeu o Limite");
            }
            else
            {
                objEspecial.SaqueEspecial(valor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nome do Titular: " + objEspecial.Titular + "\n Número da conta: " + objEspecial.NumConta + "\n Data de Criação: " + objEspecial.Abertura() + "\n Limite: " + objEspecial.Limite);
        }
    }
}
