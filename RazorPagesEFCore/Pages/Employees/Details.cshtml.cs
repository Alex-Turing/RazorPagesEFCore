using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using assignment4.Models;

namespace assignment4.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly assignment4.Models.NorthwindContext _context;

        public DetailsModel(assignment4.Models.NorthwindContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; } = default!; 
        public Employee? ReportsToEmployee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Employees == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (employee == null)
            {
                return NotFound();
            }
            
            Employee = employee;
            
            if (employee.ReportsTo.HasValue)
            {
                ReportsToEmployee = await _context.Employees
                    .FirstOrDefaultAsync(m => m.EmployeeId == employee.ReportsTo.Value);
            }
            return Page();
        }
    }
}
