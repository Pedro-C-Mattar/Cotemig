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
    public partial class Form5 : Form
    {

        DAOColaborador colaboradorC = new DAOColaborador();
        DTOColaborador colaboradorD = new DTOColaborador();

        public Form5()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = colaboradorC.ListarColaborador();
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
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text.Trim() == string.Empty)
                {
                    colaboradorD.Nome = textBox1.Text;
                    colaboradorD.Cpf = textBox2.Text;
                    colaboradorD.Telefone = textBox3.Text;
                    colaboradorD.Salario = textBox7.Text;
                    colaboradorD.Email = textBox4.Text;
                    colaboradorD.Endereco = textBox5.Text;
                    colaboradorD.DataNascimento = dateTimePicker1.Value;
                    colaboradorD.Cargo = textBox6.Text;

                    colaboradorC.InserirColaborador(colaboradorD);
                    MessageBox.Show("Colaborador Cadastrado");
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
                colaboradorD.IdColaborador = int.Parse(textBox8.Text);
                colaboradorD.Nome = textBox1.Text;
                colaboradorD.Cpf = textBox2.Text;
                colaboradorD.Telefone = textBox3.Text;
                colaboradorD.Salario = textBox7.Text;
                colaboradorD.Email = textBox4.Text;
                colaboradorD.Endereco = textBox5.Text;
                colaboradorD.DataNascimento = dateTimePicker1.Value;
                colaboradorD.Cargo = textBox6.Text;

                colaboradorC.AlterarColaborador(colaboradorD);
                MessageBox.Show("Colaborador Atualizado");
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
                    colaboradorD.IdColaborador = int.Parse(textBox8.Text);
                    colaboradorC.ExcluirColaborador(colaboradorD.IdColaborador);
                    MessageBox.Show("Colaborador Excluido");
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
