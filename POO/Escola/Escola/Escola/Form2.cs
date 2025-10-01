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
    public partial class Form2 : Form
    {

        DAOAlunos alunoC = new DAOAlunos();
        DTOAlunos alunoD = new DTOAlunos();

        public Form2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = alunoC.ListarAluno();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Trim() == string.Empty)
                {
                    alunoD.Nome = textBox1.Text;
                    alunoD.Cpf = textBox2.Text;
                    alunoD.Telefone = textBox3.Text;
                    alunoD.Email = textBox2.Text;
                    alunoD.Endereco = textBox2.Text;
                    alunoD.DataNascimento = dateTimePicker1.Value;

                    alunoC.InserirAluno(alunoD);
                    MessageBox.Show("Aluno Cadastrado");
                }
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                    alunoD.IdAluno = int.Parse(textBox6.Text);
                    alunoD.Nome = textBox1.Text;
                    alunoD.Cpf = textBox2.Text;
                    alunoD.Telefone = textBox3.Text;
                    alunoD.Email = textBox2.Text;
                    alunoD.Endereco = textBox2.Text;
                    alunoD.DataNascimento = dateTimePicker1.Value;

                    alunoC.AlterarAluno(alunoD);
                    MessageBox.Show("Aluno Atualizado");
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
                if (textBox6.Text.Trim() != string.Empty)
                {
                    alunoD.IdAluno = int.Parse(textBox6.Text);
                    alunoC.ExcluirAluno(alunoD.IdAluno);
                    MessageBox.Show("Aluno Excluido");
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
