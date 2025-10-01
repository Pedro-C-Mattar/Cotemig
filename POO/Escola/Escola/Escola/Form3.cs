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
    public partial class Form3 : Form
    {

        DAOProfessor professorC = new DAOProfessor();
        DTOProfessor professorD = new DTOProfessor();

        public Form3()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = professorC.ListarProfessor();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Trim() != string.Empty)
                {
                    professorD.IdProfessor = int.Parse(textBox6.Text);
                    professorC.ExcluirProfessor(professorD.IdProfessor);
                    MessageBox.Show("Professor Excluido");
                }
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
                if (textBox6.Text.Trim() == string.Empty)
                {
                    professorD.Nome = textBox1.Text;
                    professorD.Cpf = textBox2.Text;
                    professorD.Telefone = textBox3.Text;
                    professorD.Email = textBox2.Text;
                    professorD.Endereco = textBox2.Text;
                    professorD.DataNascimento = dateTimePicker1.Value;

                    professorC.InserirProfessor(professorD);
                    MessageBox.Show("Professor Cadastrado");
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
                professorD.IdProfessor = int.Parse(textBox6.Text);
                professorD.Nome = textBox1.Text;
                professorD.Cpf = textBox2.Text;
                professorD.Telefone = textBox3.Text;
                professorD.Email = textBox2.Text;
                professorD.Endereco = textBox2.Text;
                professorD.DataNascimento = dateTimePicker1.Value;

                professorC.AlterarProfessor(professorD);
                MessageBox.Show("Professor Atualizado");
                CarregarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
