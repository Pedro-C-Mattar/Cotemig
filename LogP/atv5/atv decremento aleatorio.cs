using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_random
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 10; i >= 1; i--)
            {
                textBox1.Text += i + " ";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i >= -10; i--)
            {
                textBox2.Text += i + " ";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            for (int i = 0; i < 1; i++)
            {
                textBox3.Text += random.Next(10000, 99999 + 1) + " ";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 1;i <= 100; i++)
            {
                if(i % 10 == 0)
                {
                    label5.Text += i + " " + "\n";
                }
                else
                {
                    label5.Text += i + " ";
                }
            }
        }
    }
}
