using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using biblioteca.Models;

namespace biblioteca.Data
{
    public class bibliotecaContext : DbContext
    {
        public bibliotecaContext (DbContextOptions<bibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<biblioteca.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<biblioteca.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<biblioteca.Models.Livro> Livro { get; set; } = default!;
    }
}
