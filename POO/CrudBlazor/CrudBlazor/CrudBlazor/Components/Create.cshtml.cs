using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CrudBlazor.Data;

namespace CrudBlazor.Components
{
    public class CreateModel : PageModel
    {
        private readonly CrudBlazor.Data.ApplicationDbContext _context;

        public CreateModel(CrudBlazor.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Filmes Filmes { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Film.Add(Filmes);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
