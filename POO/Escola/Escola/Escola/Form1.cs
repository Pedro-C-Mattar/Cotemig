using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroProfessoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 abrirProfessor = new Form3();
            abrirProfessor.ShowDialog();
        }

        private void desejaSairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cadastroAlunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 abrirAluno = new Form2();
            abrirAluno.ShowDialog();
        }

        private void cadastroColaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 abrirColaborador = new Form5();
            abrirColaborador.ShowDialog();
        }

        private void cadastroCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 abrirCurso = new Form4();
            abrirCurso.ShowDialog();
        }

        private void cadastroEndereçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 abrirEndereco = new Form6();
            abrirEndereco.ShowDialog();
        }
    }
}
