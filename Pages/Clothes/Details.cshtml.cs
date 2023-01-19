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
    public class DetailsModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public DetailsModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

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
    }
}
