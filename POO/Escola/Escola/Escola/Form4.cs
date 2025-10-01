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
    public partial class Form4 : Form
    {

        DAOCursos cursoC = new DAOCursos();
        DTOCursos cursoD = new DTOCursos();

        public Form4()
        {
            InitializeComponent();
        }

        public void CarregarGrid()
        {
            try
            {
                dataGridView1.DataSource = cursoC.ListarCurso();
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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text.Trim() == string.Empty)
                {
                    cursoD.Nome = textBox1.Text;
                    cursoD.Turno = textBox2.Text;
                    cursoD.Periodo = textBox3.Text;
                    cursoD.CargaHoraria = textBox4.Text;

                    cursoC.InserirCurso(cursoD);
                    MessageBox.Show("Curso Cadastrado");
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
                cursoD.IdCurso = int.Parse(textBox6.Text);
                cursoD.Nome = textBox1.Text;
                cursoD.Turno = textBox2.Text;
                cursoD.Periodo = textBox3.Text;
                cursoD.CargaHoraria = textBox2.Text;

                cursoC.AlterarCurso(cursoD);
                MessageBox.Show("Curso Atualizado");
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
                    cursoD.IdCurso = int.Parse(textBox6.Text);
                    cursoC.ExcluirCurso(cursoD.IdCurso);
                    MessageBox.Show("Curso Excluido");
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
