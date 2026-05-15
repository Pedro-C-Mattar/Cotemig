using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CrudBlazor.Data;

namespace CrudBlazor.Components
{
    public class EditModel : PageModel
    {
        private readonly CrudBlazor.Data.ApplicationDbContext _context;

        public EditModel(CrudBlazor.Data.ApplicationDbContext context)
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

            var filmes =  await _context.Film.FirstOrDefaultAsync(m => m.Id == id);
            if (filmes == null)
            {
                return NotFound();
            }
            Filmes = filmes;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Filmes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmesExists(Filmes.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool FilmesExists(int id)
        {
            return _context.Film.Any(e => e.Id == id);
        }
    }
}
