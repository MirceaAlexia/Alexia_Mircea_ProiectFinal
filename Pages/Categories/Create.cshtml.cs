using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;

namespace Alexia_Mircea_ProiectFinal.Pages.Categories
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
            return Page();
        }

        [BindProperty]
        public Category Category { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Category.Add(Category);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
