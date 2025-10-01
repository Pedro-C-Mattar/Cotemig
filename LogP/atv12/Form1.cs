using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_mte
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
            divisores(num);
        }
        public void divisores(int num)
        {
            textBox2.Text = "";
            int div = 0;
            for (int i = 1; i < num+1; i++)
            {
                if (num % i == 0)
                {
                    div++;
                }
            }
            textBox2.Text = div.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox4.Text);
            int num2 = int.Parse(textBox5.Text);
            int num3 = int.Parse(textBox6.Text);
            maior(num1, num2, num3);
        }
        public void maior(int num1, int num2, int num3)
        {
            textBox3.Text = "";
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    textBox3.Text = num1.ToString();
                }
            }
            if (num2 > num1)
            {
                if (num2 > num3)
                {
                    textBox3.Text = num2.ToString();
                }
            }
            if (num3 > num1)
            {
                if (num3 > num2)
                {
                    textBox3.Text = num3.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cod = textBox7.Text;
            reverse(cod);
        }
        public void reverse(string cod)
        {
            textBox8.Text = "";
            for(int i = cod.Length - 1; i >= 0; i--)
            {
                textBox8.Text += cod[i].ToString() + " ";
            }
        }
    }
}
