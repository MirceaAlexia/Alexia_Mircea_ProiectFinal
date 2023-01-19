using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;
using System.Security.Policy;

namespace Alexia_Mircea_ProiectFinal.Pages.Clothes
{
    public class CreateModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public CreateModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryID"] = new SelectList(_context.Set<Category>(), "ID", "CategoryName");
            return Page();
        }

        [BindProperty]
        public Clothing Clothing { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Clothing.Add(Clothing);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
