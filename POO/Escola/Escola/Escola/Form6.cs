using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Escola.DTO;
using Escola.BLL;

namespace Escola
{
    public partial class Form6 : Form
    {

        DAOEnderecos enderecoC = new DAOEnderecos();
        DTOEnderecos enderecoD = new DTOEnderecos();

        public Form6()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = enderecoC.ListarEndereco();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                enderecoD.IdEndereco = int.Parse(textBox8.Text);
                enderecoD.Logradouro = textBox1.Text;
                enderecoD.Numero = textBox2.Text;
                enderecoD.Complemento = textBox3.Text;
                enderecoD.Bairro = textBox7.Text;
                enderecoD.Cep = textBox4.Text;
                enderecoD.Cidade = textBox5.Text;
                enderecoD.Estado = textBox6.Text;

                enderecoC.AlterarEndereco(enderecoD);
                MessageBox.Show("Colaborador Atualizado");
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Trim() == string.Empty)
                {
                    enderecoD.Logradouro = textBox1.Text;
                    enderecoD.Numero = textBox2.Text;
                    enderecoD.Complemento = textBox3.Text;
                    enderecoD.Bairro = textBox7.Text;
                    enderecoD.Cep = textBox4.Text;
                    enderecoD.Cidade = textBox5.Text;
                    enderecoD.Estado = textBox6.Text;

                    enderecoC.InserirEndereco(enderecoD);
                    MessageBox.Show("Endereco Cadastrado");
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Trim() != string.Empty)
                {
                    enderecoD.IdEndereco = int.Parse(textBox8.Text);
                    enderecoC.ExcluirEndereco(enderecoD.IdEndereco);
                    MessageBox.Show("Endereco Excluido");
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
