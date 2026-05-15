using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using biblioteca.Models;
using System.Threading.Tasks;

namespace biblioteca.DTO
{
    public class LivroDTO
    {
        public int LivroId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}
