using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ProjetoPessoa
{
    class Pessoa
    {
        private string nome;
        private DateTime dataNascimento;
        private double altura;
        private double dependentes;


        public string Nome
        {
            set
            {

               if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido.");
                }
            }
            get { return this.nome; }
        }
        
        
        public DateTime DataNascimento
        {
            set { this.dataNascimento = value; }
            get { return this.dataNascimento; }
        }

        public double Altura
        {
            set 
            {
                if (value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    //MessageBox.Show("teste");
                    throw new Exception("A altura deve ser acima de 1m.");
                }
            }
            get { return this.altura; }
        }

        public string ImprimeDados()
        {
            return "Dados da pessoa: \n\nNome: " + 
                    this.nome + "\nData de Nascimento: " +
                    this.dataNascimento.ToString("dd/MM/yyyy") + 
                    "\nAltura: " + this.altura.ToString("0.00") + "m."+
                    "\nResponsaveis: " + this.dependentes.ToString();
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.dataNascimento.Year;
        }
        public double Dependentes
        {
            set { this.dependentes = value; }
            get { return this.dependentes; }
        }
       
        public double CalcularPlano()
        {
            if (dependentes > 0 && dependentes < 3 )
            {
                return dependentes * 150;
            }
            else if(dependentes > 2 && dependentes < 5 )
            {
                return dependentes * 140;
            }
            else
            {
                return dependentes * 120;
            }
        }
    }
}
