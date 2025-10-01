using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola.DTO
{
    internal class DTOEnderecos
    {
        private string logradouro, numero, complemento, bairro, cep, cidade, estado;
        private int idEndereco;

        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public int IdEndereco { get => idEndereco; set => idEndereco = value; }
    }
}
