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
    public class DeleteModel : PageModel
    {
        private readonly CrudBlazor.Data.ApplicationDbContext _context;

        public DeleteModel(CrudBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Filmes Filmes { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmes = await _context.Film.FirstOrDefaultAsync(m => m.Id == id);

            if (filmes == null)
            {
                return NotFound();
            }
            else
            {
                Filmes = filmes;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var filmes = await _context.Film.FindAsync(id);
            if (filmes != null)
            {
                Filmes = filmes;
                _context.Film.Remove(Filmes);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
