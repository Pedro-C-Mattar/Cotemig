using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace biblioteca.Models
{
    public class Livro
    {
        [Key]
        public int LivroId { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Sinopse { get; set; }
        [Required]
        public string Categoria { get; set; }
    }
}
