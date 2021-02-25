using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MegaDesk.Data;
using MegaDesk.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging.EventSource;

namespace MegaDesk.Pages.DeskQuotes
{
    public class IndexModel : PageModel
    {
        private readonly MegaDesk.Data.MegaDeskContext _context;

        public IndexModel(MegaDesk.Data.MegaDeskContext context)
        {
            _context = context;
        }

        public IList<DeskQuote> DeskQuote { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList SortOrderList { get; set; }
        [BindProperty(SupportsGet = true)]
        public string sortOrder { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<string> orderQuery = from o in _context.DeskQuote
                orderby o.CustomerName
                select o.CustomerName;

            var quotes = from q in _context.DeskQuote
                select q;

            if (!string.IsNullOrEmpty(SearchString))
            {
                quotes = quotes.Where(keyword => keyword.CustomerName.Contains(SearchString));
            }

            switch (sortOrder)
            {
                case "1":
                    quotes = quotes.OrderBy(s => s.CustomerName);
                    break;
                case "2":
                    quotes = quotes.OrderByDescending(s => s.CustomerName);
                    break;
                case "3":
                    quotes = quotes.OrderByDescending(s => s.QuoteDate);
                    break;
                default:
                    quotes = quotes.OrderBy(s => s.QuoteDate);
                    break;
            }


            DeskQuote = await quotes.ToListAsync();
        }
    }
}
