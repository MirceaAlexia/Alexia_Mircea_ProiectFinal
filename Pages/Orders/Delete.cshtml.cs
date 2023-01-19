using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;

namespace Alexia_Mircea_ProiectFinal.Pages.Orders
{
    public class DeleteModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public DeleteModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }

            var order = await _context.Order.FirstOrDefaultAsync(m => m.ID == id);

            if (order == null)
            {
                return NotFound();
            }
            else 
            {
                Order = order;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Order == null)
            {
                return NotFound();
            }
            var order = await _context.Order.FindAsync(id);

            if (order != null)
            {
                Order = order;
                _context.Order.Remove(Order);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
