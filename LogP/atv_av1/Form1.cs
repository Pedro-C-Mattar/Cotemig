namespace projetinho_do_mario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = double.Parse(textBox1.Text);
            double v2 = double.Parse(textBox2.Text);
            double v3 = 0;

            v3 = v2;
            v2 = v1;
            v1 = v3;

            MessageBox.Show(" Valor V1: " + v1);
            MessageBox.Show(" Valor V2: " + v2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox3.Text);
            double n2 = double.Parse(textBox4.Text);

            double resultado = n1 + n2;

            if (resultado > 20)
            {

                resultado = resultado + 8;
                MessageBox.Show("O valor da soma é: " + resultado);

            }
            else
            {

                resultado = resultado - 5;
                MessageBox.Show("O valor da soma é: " + resultado);

            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double num = double.Parse(textBox5.Text);
            double resultadooo = 0;

            if (num >= 0)
            {

                resultadooo = Math.Sqrt(num);
                MessageBox.Show(" Resultado é: " + resultadooo);

            }


            else
            {

                resultadooo = Math.Pow(num, 2);
                MessageBox.Show(" Resultado é: " + resultadooo);

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {

            double nume = double.Parse(textBox6.Text);

            if (nume % 3 == 0)
            {

                MessageBox.Show(" Múltiplo de 3 ");

            }
            else
            {

                MessageBox.Show(" Não Múltiplo de 3 ");

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            double num1 = double.Parse(textBox7.Text);
            double num2 = double.Parse(textBox8.Text);

            if (num1 > num2)
            {

                MessageBox.Show(" Maior Número é: " + num1);

            }
            else
            {

                MessageBox.Show(" Maior Número é: " + num2);

            }

        }

        private void button6_Click(object sender, EventArgs e)
        {

            string nome = textBox9.Text;
            double idad = double.Parse(textBox10.Text);
            double salar = double.Parse(textBox11.Text);
            string sexo = comboBox1.Text;

            if (sexo == "Feminino")
            {

                MessageBox.Show(nome + " tem o salário de " + salar + " reais ");

            }
            else
            {

                MessageBox.Show(nome + " tem a idade de " + idad + " anos ");

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            double nume1 = double.Parse(textBox12.Text);
            double nume2 = double.Parse(textBox13.Text);
            double meno = 0;
            double maio = 0;


            if (nume1 > nume2)
            {

                meno = Math.Pow(nume2, 2);
                MessageBox.Show(" Quadrado do Menor: " + meno);
                if (nume1 >= 0)
                {

                    maio = Math.Sqrt(nume1);
                    MessageBox.Show(" Raiz do Maior: " + maio);

                }
                else
                {

                    MessageBox.Show(" Impossível calcular a raiz do maior. ");

                }

            }
            else
            {

                meno = Math.Pow(nume1, 2);
                MessageBox.Show(" Quadrado do Menor: " + meno);
                if (nume2 >= 0)
                {

                    maio = Math.Sqrt(nume2);
                    MessageBox.Show(" Raiz do Maior: " + maio);

                }
                else
                {

                    MessageBox.Show(" Impossível calcular a raiz do maior. ");

                }

            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

            double numero1 = double.Parse(textBox14.Text);
            double numero2 = double.Parse(textBox15.Text);
            string opera = comboBox2.Text;
            double resultadoo = 0;

            if (opera == "soma")
            {

                resultadoo = numero1 + numero2;
                MessageBox.Show(" Resultado é: " + resultadoo);

            }
            else if (opera == "subtração")
            {

                resultadoo = numero1 - numero2;
                MessageBox.Show(" Resultado é: " + resultadoo);

            }
            else if (opera == "multiplicação")
            {

                resultadoo = numero1 * numero2;
                MessageBox.Show(" Resultado é: " + resultadoo);

            }
            else
            {

                resultadoo = numero1 / numero2;
                MessageBox.Show(" Resultado é: " + resultadoo);

            }

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

            double quant = double.Parse(textBox16.Text);
            string pao = comboBox3.Text;
            double preco = 0;

            if (pao == "Pão de Sal")
            {

                preco = quant * 0.30;
                MessageBox.Show(" Preço total é de: " + preco + " reais ");

            }
            else
            {

                preco = quant * 0.50;
                MessageBox.Show(" Preço total é de: " + preco + " reais ");

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {

            double gasoli = double.Parse(textBox17.Text);

            if (gasoli <= 10)
            {

                MessageBox.Show(" Cliente ganhou um chaveiro. ");

            }
            else if ((gasoli > 10) && (gasoli <= 30))
            {

                MessageBox.Show(" Cliente ganhou uma ducha no carro. ");

            }
            else if ((gasoli > 30) && (gasoli <= 40))
            {

                MessageBox.Show(" Cliente ganhou uma troca de óleo. ");

            }
            else
            {

                MessageBox.Show(" Cliente ganhou uma ducha de carro e também uma troca de óleo. ");

            }

        }
    }
}