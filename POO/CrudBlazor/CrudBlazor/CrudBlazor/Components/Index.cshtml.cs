using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Data;

namespace CrudBlazor.Components
{
    public class IndexModel : PageModel
    {
        private readonly CrudBlazor.Data.ApplicationDbContext _context;

        public IndexModel(CrudBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Filmes> Filmes { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Filmes = await _context.Film.ToListAsync();
        }
    }
}
