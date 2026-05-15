using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
namespace biblioteca.Models
{
    public class Funcionario
    {
        [Key]
        public int FuncionarioId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Funcao { get; set; }
        [Required]
        public int Idade { get; set; }
    }
}
