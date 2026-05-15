using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CrudBlazor.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Cidade>Cid {  get; set; }
        public DbSet<Pais>Pai { get; set; }
        public DbSet<Estado>Est { get; set; }
    }
}
