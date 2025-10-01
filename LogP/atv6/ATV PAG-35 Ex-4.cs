using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atv_pagina_35
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;
            string matricula = textBox4.Text;
            double hr = double.Parse(textBox2.Text);
            double hrex = double.Parse(textBox3.Text);
            double resultadoa = 0.00;
            double resultadob = 0.00;
            double resultadoc = 0.00;
            double resultadod = 0.00;

            switch (codigo)
            {

                case "1":
                    resultadoa = hr * 8;
                    resultadob = hrex * (8 * 1.5);
                    resultadoc = (hr * 8) * 0.11;
                    resultadod = (hr * 8) + (hrex * (8 * 1.5)) - ((hr * 8) * 0.11);
                    MessageBox.Show(" a) " + resultadoa);
                    MessageBox.Show(" b) " + resultadob);
                    MessageBox.Show(" c) " + resultadoc);
                    MessageBox.Show(" d) " + resultadod);
                    break;

                case "2":
                    resultadoa = hr * 10;
                    resultadob = hrex * (10 * 1.5);
                    resultadoc = (hr * 10) * 0.11;
                    resultadod = (hr * 10) + (hrex * (10 * 1.5)) - ((hr * 10) * 0.11);
                    MessageBox.Show(" a) " + resultadoa);
                    MessageBox.Show(" b) " + resultadob);
                    MessageBox.Show(" c) " + resultadoc);
                    MessageBox.Show(" d) " + resultadod);
                    break;

                case "3":
                    resultadoa = hr * 12;
                    resultadob = hrex * (12 * 1.5);
                    resultadoc = (hr * 12) * 0.11;
                    resultadod = (hr * 12) + (hrex * (12 * 1.5)) - ((hr * 12) * 0.11);
                    MessageBox.Show(" a) " + resultadoa);
                    MessageBox.Show(" b) " + resultadob);
                    MessageBox.Show(" c) " + resultadoc);
                    MessageBox.Show(" d) " + resultadod);
                    break;

                case "4":
                    resultadoa = hr * 15;
                    resultadob = hrex * (15 * 1.5);
                    resultadoc = (hr * 15) * 0.11;
                    resultadod = (hr * 15) + (hrex * (15 * 1.5)) - ((hr * 15) * 0.11);
                    MessageBox.Show(" a) " + resultadoa);
                    MessageBox.Show(" b) " + resultadob);
                    MessageBox.Show(" c) " + resultadoc);
                    MessageBox.Show(" d) " + resultadod);
                    break;

                case "5":
                    resultadoa = hr * 20;
                    resultadob = hrex * (20 * 1.5);
                    resultadoc = (hr * 20) * 0.11;
                    resultadod = (hr * 20) + (hrex * (20 * 1.5)) - ((hr * 20) * 0.11);
                    MessageBox.Show(" a) " + resultadoa);
                    MessageBox.Show(" b) " + resultadob);
                    MessageBox.Show(" c) " + resultadoc);
                    MessageBox.Show(" d) " + resultadod);
                    break;

            }
        }
    }
}
