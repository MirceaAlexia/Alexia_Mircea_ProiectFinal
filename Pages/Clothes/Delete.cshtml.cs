using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;

namespace Alexia_Mircea_ProiectFinal.Pages.Clothes
{
    public class DeleteModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public DeleteModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Clothing Clothing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Clothing == null)
            {
                return NotFound();
            }

            var clothing = await _context.Clothing.FirstOrDefaultAsync(m => m.ID == id);

            if (clothing == null)
            {
                return NotFound();
            }
            else 
            {
                Clothing = clothing;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Clothing == null)
            {
                return NotFound();
            }
            var clothing = await _context.Clothing.FindAsync(id);

            if (clothing != null)
            {
                Clothing = clothing;
                _context.Clothing.Remove(Clothing);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
