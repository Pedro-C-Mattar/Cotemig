using System;
using System.Windows.Forms;

namespace Página_82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnQ1_Click(object sender, EventArgs e)
        {
            labelQ1.Text = string.Empty;
            int[,] mat = new int[3, 4];
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = linha * coluna;
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    lblQ1.Text += mat[linha, coluna] + " ";
                }
                labelQ1.Text += "\n";
            }
        }

        private void BtnQ2_Click(object sender, EventArgs e)
        {
            labelQ2.Text = string.Empty;
            int[,] mat = new int[4, 4];
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = coluna;
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    labelQ2.Text += mat[linha, coluna] + " ";
                }
                labelQ2.Text += "\n";
            }
        }

        private void BtnQ3_Click(object sender, EventArgs e)
        {
            labelQ3.Text = string.Empty;
            Random random = new Random();
            int[,] mat = new int[5, 3];
            int soma = 0;
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = random.Next(0, 9 + 1);
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    labelQ3.Text += mat[linha, coluna] + " ";
                    soma += mat[linha, coluna];
                }
                labelQ3.Text += "\n";
            }
            float Media = (float)soma / mat.Length;
            labelMedia.Text = "Média: " + Media;
        }

        private void BtnQ4_Click(object sender, EventArgs e)
        {
            labelQ5.Text = string.Empty;
            int[,] mat = new int[3, 3];
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = 0;
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    if (linha == coluna)
                        labelQ5.Text += mat[linha, coluna] + " ";
                    else
                        labelQ5.Text += "  ";
                }
                labelQ5.Text += "\n";
            }
        }

        private void BtnQ6_Click(object sender, EventArgs e)
        {
            labelQ6.Text = string.Empty;
            labelSoma.Text = "Soma Final: ";
            labelVetor.Text = "Vetor: ";
            Random random = new Random();
            int[,] mat = new int[4, 6];
            int[] SomaColuna = new int[6];
            int SomaFinal = 0;
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = random.Next(0, 9 + 1);
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    labelQ6.Text += mat[linha, coluna] + " ";
                    SomaColuna[coluna] += mat[linha, coluna];
                }
                labelQ6.Text += "\n";
            }
            for (int i = 0; i < SomaColuna.Length; i++)
            {
                labelVetor.Text += SomaColuna[i] + " ";
                SomaFinal += SomaColuna[i];
            }
            labelSoma.Text += SomaFinal;
        }

        private void BtnQ7_Click(object sender, EventArgs e)
        {
            labelQ7a.Text = string.Empty;
            Random random = new Random();
            int[,] mat1 = new int[3, 5];
            int[,] mat2 = new int[3, 5];
            int[,] mat3 = new int[3, 5];
            for (int linha = 0; linha < mat1.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat1.GetLength(1); coluna++)
                {
                    mat1[linha, coluna] = random.Next(10, 49 + 1);
                    labelQ7a.Text += mat1[linha, coluna] + " ";
                }
                labelQ7a.Text += "\n";
            }
            for (int linha = 0; linha < mat2.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat2.GetLength(1); coluna++)
                {
                    mat2[linha, coluna] = random.Next(10, 49 + 1);
                    labelQ7b.Text += mat2[linha, coluna] + " ";
                }
                labelQ7b.Text += "\n";
            }
            for (int linha = 0; linha < mat3.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat3.GetLength(1); coluna++)
                {
                    mat3[linha, coluna] = (mat1[linha, coluna]) + (mat2[linha, coluna]);
                    labelQ7c.Text += mat3[linha, coluna] + " ";
                }
                labelQ7c.Text += "\n";
            }
        }

        private void BtnQ9_Click(object sender, EventArgs e)
        {
            labelQ9.Text = string.Empty;
            labelQ9Transp.Text = string.Empty;
            int[,] mat = new int[3, 5];
            int[,] matT = new int[mat.GetLength(1), mat.GetLength(0)];
            Random random = new Random();
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    mat[linha, coluna] = random.Next(1, 9 + 1);
                }
            }
            for (int linha = 0; linha < mat.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < mat.GetLength(1); coluna++)
                {
                    labelQ9.Text += mat[linha, coluna] + " ";
                }
                labelQ9.Text += "\n";
            }
            for (int linha = 0; linha < matT.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matT.GetLength(1); coluna++)
                {
                    matT[linha, coluna] = mat[coluna, linha];
                    labelQ9Transp.Text += matT[linha, coluna] + " ";
                }
                labelQ9Transp.Text += "\n";
            }
        }
    }
}
