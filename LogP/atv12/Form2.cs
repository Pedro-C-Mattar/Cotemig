using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            MessageBox.Show(MostrarCubo(num).ToString());
        }
        public int MostrarCubo(int num)
        {
         return num*num*num;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox2.Text);
            MessageBox.Show(MostrarFatorial(num).ToString());
        }

        public int MostrarFatorial(int num)
        {
            for(int i = num - 1; i > 1; i--)
            {
                num = num * i;
            }
            return num;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox3.Text);
            MessageBox.Show(MostrarDiv(num).ToString());
            MessageBox.Show(MostrarPrimo(num));
        }
        public int MostrarDiv(int num)
        {
            int num2 = 0;
            for (int i = num; i > 0; i--)
            {
                if(num % i == 0)
                {
                    num2++;
                }
            }
            return num2;
        }
        public string MostrarPrimo(int num)
        {
            string rp = "Primo";
            if(MostrarDiv(num) != 2)
            {
                rp = "Nao é Primo";
            }
            return rp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int num3 = int.Parse(textBox6.Text);
            MessageBox.Show("O maior é:" + " " + MostrarMax(num,num2,num3));
            MessageBox.Show("O menor é:" + " " + MostrarMim(num, num2, num3));
            MessageBox.Show("A media é:" + " " + MostrarMed(num, num2, num3));

        }
        public string MostrarMax(int num, int num2, int num3)
        {
            int maior = 0;
            if (num > num2)
            {
                if(num > num3)
                {
                    maior = num;
                }
            }
            else if (num2 > num3)
            {
                maior = num2;
            }
            else if (num < num3)
            {
                maior = num3;
            }
            return maior.ToString();
        }
        public string MostrarMim(int num, int num2, int num3)
        {
            int menor = 0;
            if (num < num2)
            {
                if (num < num3)
                {
                    menor = num;
                }
            }
            else if (num2 < num3)
            {
                menor = num2;
            }
            else if (num > num3)
            {
                menor = num3;
            }
            return menor.ToString();
        }
        public string MostrarMed(int num, int num2, int num3)
        {
            return (((num + num2 + num3) / 3)).ToString();
        }
    }
}
