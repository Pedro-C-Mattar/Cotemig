using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_DoWhile_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int contador = 100;
            while(contador <= 200)
            {
                textBox1.Text += contador + " ";
                contador++;

            }

            contador = 100;

            do
            {
                textBox2.Text += contador + " ";
                contador++;
            } while (contador <= 200);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int contimp = 0;
            int contpar = 0;
            do
            {
                textBox3.Text += contador + " ";
               
                if(contador % 2 == 0)
                {
                    contpar = contpar + 1;
                }
                else
                {
                    contimp = contimp + 1;
                }
                contador++;
            } while (contador <= 10);

            MessageBox.Show(" Quantidade de pares: " + contpar);
            MessageBox.Show(" Quantidade de ímpares: " + contimp);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int limite = int.Parse(textBox4.Text);
            do
            {
                textBox5.Text += contador + " ";
                contador++;
            } while (contador <= limite);
        }
    }
}
