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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Escola
{
    public partial class Form7 : Form
    {

        DAODisciplinas disciplinaC = new DAODisciplinas();
        DTODisciplinas disciplinaD = new DTODisciplinas();

        public Form7()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = disciplinaC.ListarDisciplina();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Trim() == string.Empty)
                {
                    disciplinaD.Nome = textBox1.Text;
                    disciplinaD.DiaDaSemana = textBox2.Text;
                    disciplinaD.Turno = textBox3.Text;
                    disciplinaD.CargaHoraria = textBox4.Text;
                    disciplinaD.Horario = textBox5.Text;

                    disciplinaC.InserirDisciplina(disciplinaD);
                    MessageBox.Show("Disciplina Cadastrado");
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
                disciplinaD.IdDisciplina = int.Parse(textBox6.Text);
                disciplinaD.Nome = textBox1.Text;
                disciplinaD.DiaDaSemana = textBox2.Text;
                disciplinaD.Turno = textBox3.Text;
                disciplinaD.CargaHoraria = textBox4.Text;
                disciplinaD.Horario = textBox5.Text;

                disciplinaC.AlterarDisciplina(disciplinaD);
                MessageBox.Show("Disciplina Atualizado");
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
                    disciplinaD.IdDisciplina = int.Parse(textBox6.Text);
                    disciplinaC.ExcluirDisciplina(disciplinaD.IdDisciplina);
                    MessageBox.Show("Disciplina Excluido");
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
