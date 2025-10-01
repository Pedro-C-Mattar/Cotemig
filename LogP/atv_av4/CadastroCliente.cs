using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAppEscola
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }
        string tabela = "tblCliente";
        ConexaoCliente bd = new ConexaoCliente();
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }
        public void ExibirDados()
        {
            //Formatar o comando
            string dados = $"SELECT * FROM {tabela}";
            //Recuperar os dados no banco
            DataTable dt = bd.ExecutarConsulta(dados);
            //Passar o resultado para o DataGridView
            dtgAluno.DataSource = dt.AsDataView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string inserir;
            

            if(txtNome.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "" && txtLogradouro.Text != "" && txtNumero.Text != "")
            {
                inserir = $"INSERT INTO {tabela} VALUES(NULL, '{txtNome.Text}', '{txtLogradouro.Text}', '{txtNumero.Text}', '{txtBairro.Text}', '{txtCidade.Text}', '{txtEstado.Text}')";
                int resultado = bd.ExecutarComandos(inserir);
                if(resultado == 1)
                {
                    MessageBox.Show("Dados inseridos com sucesso!");
                    LimpaCampos();
                    ExibirDados();
                }
                else
                {
                    MessageBox.Show("Erro ao inserir o dado!");
                }

            }
            else
            {
                MessageBox.Show("Dados inválido!");
            }


        }
        public void LimpaCampos()
        {
            txtNome.Clear();
            txtLogradouro.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtNome.Clear();
            txtEstado.Clear();
        }

        private void dtgAluno_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLogradouro.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumero.Text = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtBairro.Text = dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCidade.Text = dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEstado.Text = dtgAluno.Rows[e.RowIndex].Cells[6].Value.ToString();

            

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string deletar = $"DELETE FROM {tabela} WHERE id = {lblID.Text}";
            if(lblID.Text != "")
            {
                int resultado = bd.ExecutarComandos(deletar);
                if(resultado == 1)
                {
                    MessageBox.Show("Dado excluído com sucesso");
                    LimpaCampos();
                    ExibirDados();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir o dado");
                }
            }
            else
            {
                MessageBox.Show("Campo ID não identificado");
            }

        }


        private void dtgAluno_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
        {
            e.ToolTipText = "Clique para atualizar ou deletar";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string alterar;
            

            if (txtNome.Text != "" && txtBairro.Text != "" && txtCidade.Text != "" && txtEstado.Text != "" && txtLogradouro.Text != "" && txtNumero.Text != "")
            {
                alterar = $"UPDATE {tabela} set nome = '{txtNome.Text}', logradouro = '{txtLogradouro.Text}', Numero = '{txtNumero.Text}', Bairro = '{txtBairro.Text}', Cidade = '{txtCidade.Text}', Estado = '{txtEstado.Text}' WHERE id = '{lblID.Text}'";
                int resultado = bd.ExecutarComandos(alterar);
                if(resultado == 1)
                {
                    MessageBox.Show("Dados atualizados com sucesso");
                    LimpaCampos();
                    ExibirDados();
                }
                else
                {
                    MessageBox.Show("Atualização não sucedida");
                }
            }   
            else
            {
                MessageBox.Show("Dados Invalidos");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
