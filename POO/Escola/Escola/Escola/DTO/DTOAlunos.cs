using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DTO
{
    internal class DTOAlunos
    {
        private string nome, cpf, telefone, email, endereco;
        private int idAluno;
        private DateTime dataNascimento;

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public int IdAluno { get => idAluno; set => idAluno = value; }
    }
}
