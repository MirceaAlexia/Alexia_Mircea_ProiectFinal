using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Alexia_Mircea_ProiectFinal.Data;
using Alexia_Mircea_ProiectFinal.Models;
using Alexia_Mircea_ProiectFinal.Pages.Clothes;

namespace Alexia_Mircea_ProiectFinal.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext _context;

        public IndexModel(Alexia_Mircea_ProiectFinal.Data.Alexia_Mircea_ProiectFinalContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;
        public IList<Clothing> Clothing { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Order != null)
            {
                Order = await _context.Order.Include(b => b.Clothing).ToListAsync();
            }
            if (_context.Clothing != null)
            {
                Clothing = await _context.Clothing.Include(b => b.Category).ToListAsync();
            }
        }
    }
}
