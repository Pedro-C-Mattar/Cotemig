using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj_importante_form
{
    public partial class frmAluno : Form
    {
        public frmAluno()
        {
            InitializeComponent();
        }
        string tabela = "tblAlunos";
        ConexaoAluno bd = new ConexaoAluno();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            ExibirDados();
        }

        public void ExibirDados()
        {
            //Formatar o comando
            string dados = $"SELECT * FROM {tabela}";
            //Recuperar os dados do banco
            DataTable dt = bd.ExecutarConsulta(dados);
            //Passar o resultado para o DataGridView
            dtgAluno.DataSource = dt.AsDataView();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string inserir;
            char unidade = rdbBarroca.Checked ? 'B' : 'F';
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cbxTurma.Text;
            int idade;

            if(txtNome.Text != "" && int.TryParse(txtIdade.Text, out idade))
            {
                inserir = $"INSERT INTO {tabela} VALUES(NULL, '{txtNome.Text}', '{idade}', '{unidade}', '{serie}', '{turma}')";
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
                MessageBox.Show("Nome ou idade inserido incorretamente!");
            }
        }
        public void LimpaCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            rdbBarroca.Checked = false;
            rdbFloresta.Checked = false;
            rdbSerie1.Checked = false;
            rdbSerie2.Checked = false;
            rdbSerie3.Checked = false;
            cbxTurma.Text = "";
            txtNome.Focus();
        }

        private void dtgAluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dtgAluno.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgAluno.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIdade.Text = dtgAluno.Rows[e.RowIndex].Cells[2].Value.ToString();
            string unidade = dtgAluno.Rows[e.RowIndex].Cells[3].Value.ToString();
            //unidade = rdbBarroca.Checked ? rdbBarroca = true : rdbFloresta = true;
            if (unidade == "B")
            {
                rdbBarroca.Checked = true;
            }
            else
            {
                rdbFloresta.Checked = true;
            }

            string serie = dtgAluno.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (serie == "1")
            {
                rdbSerie1.Checked = true;
            }
            else if (serie == "2")
            {
                rdbSerie2.Checked = true;
            }
            else
            {
                rdbSerie3.Checked = true;
            }

            cbxTurma.Text = dtgAluno.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string deletar = $"DELETE FROM {tabela} WHERE id = {lblID.Text}";
            if (lblID.Text != "")
            {
                int resultado = bd.ExecutarComandos(deletar);
                if (resultado == 1)
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
            char unidade = rdbBarroca.Checked ? 'B' : 'F';
            int serie = rdbSerie1.Checked ? 1 : rdbSerie2.Checked ? 2 : 3;
            string turma = cbxTurma.Text;
            int idade;

            if (txtNome.Text != "" && int.TryParse(txtIdade.Text, out idade))
            {
                alterar = $"UPDATE {tabela} set nome = '{txtNome.Text}', idade = '{idade}', unidade = '{unidade}', turma = '{turma}', serie = '{serie}' WHERE id = '{lblID.Text}'";
                int resultado = bd.ExecutarComandos(alterar);
                if (resultado == 1)
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                    LimpaCampos();
                    ExibirDados();
                }
                else
                {
                    MessageBox.Show("Atualização não sucedida!");
                }
            }
            else
            {
                MessageBox.Show("Dados inválidos!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}