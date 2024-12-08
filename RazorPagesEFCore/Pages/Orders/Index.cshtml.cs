using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using assignment4.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;

namespace assignment4.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly NorthwindContext _context;

        public IndexModel(NorthwindContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; } = default!;

        public SelectList Employees { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int? SelectedEmployeeId { get; set; }

        public async Task OnGetAsync()
        {
             // Populate the drop-down list
            Employees = new SelectList(
                (await _context.Employees
                    .OrderBy(e => e.LastName)
                    .ToListAsync())
                    .Select(e => new { e.EmployeeId, FullName = $"{e.FirstName} {e.LastName}"}),
                "EmployeeId",
                "FullName"
            );

            // Query orders with optional filtering
            IQueryable<Order> ordersQuery = _context.Orders
                .Include(o => o.Employee)
                .Include(o => o.ShipViaNavigation)
                .Where(o => o.Freight >= 250);

            if (SelectedEmployeeId.HasValue)
            {
                ordersQuery = ordersQuery.Where(o => o.EmployeeId == SelectedEmployeeId);
            }

            Order = await ordersQuery.ToListAsync();
        }
    }
}
