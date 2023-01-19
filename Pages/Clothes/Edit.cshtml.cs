using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;

namespace Alexia_Mircea_ProiectFinal.Pages.Clothes
{
    public class EditModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public EditModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Clothing Clothing { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Clothing == null)
            {
                return NotFound();
            }

            var clothing =  await _context.Clothing.FirstOrDefaultAsync(m => m.ID == id);
            if (clothing == null)
            {
                return NotFound();
            }
            Clothing = clothing;
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
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

            _context.Attach(Clothing).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClothingExists(Clothing.ID))
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

        private bool ClothingExists(int id)
        {
          return _context.Clothing.Any(e => e.ID == id);
        }
    }
}
