using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATV1___metod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Metodos acesso = new Metodos();

        private void button1_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double resul1 = acesso.Soma(n1, n2, n3, n4, n5);

            MessageBox.Show("A soma dos números é: "+ resul1.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double resul2 = acesso.Media(n1, n2, n3, n4, n5);

            MessageBox.Show("A media dos números é: " + resul2.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double resul3 = acesso.Maior(n1, n2, n3, n4, n5);

            MessageBox.Show("O maior dos números é: " + resul3.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double resul4 = acesso.Menor(n1, n2, n3, n4, n5);

            MessageBox.Show("O menor dos números é: " + resul4.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);
            double n4 = double.Parse(textBox4.Text);
            double n5 = double.Parse(textBox5.Text);

            double resul5 = acesso.Potencia(n2, n3);

            MessageBox.Show("O 2º número elevado ao 3º número é: " + resul5.ToString());
        }
    }
}
