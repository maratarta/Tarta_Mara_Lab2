using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Tarta_Mara_Lab2.Data;
using Tarta_Mara_Lab2.Models;

namespace Tarta_Mara_Lab2.Pages.Borrowings
{
    public class IndexModel : PageModel
    {
        private readonly Tarta_Mara_Lab2.Data.Tarta_Mara_Lab2Context _context;

        public IndexModel(Tarta_Mara_Lab2.Data.Tarta_Mara_Lab2Context context)
        {
            _context = context;
        }

        public IList<Borrowing> Borrowing { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Borrowing = await _context.Borrowing
                .Include(b => b.Book)
                .Include(b => b.Member).ToListAsync();
        }
    }
}
