using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using biblioteca.Models;
using System.Threading.Tasks;

namespace biblioteca.DTO
{
    public class ClienteDTO
    {
        public int ClienteId { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Idade { get; set; }
    }   
}