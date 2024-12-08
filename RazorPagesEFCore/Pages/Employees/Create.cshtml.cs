using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using assignment4.Models;

namespace assignment4.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private readonly assignment4.Models.NorthwindContext _context;

        public CreateModel(assignment4.Models.NorthwindContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ReportsTo"] = new SelectList(_context.Employees.Select(e => new {
                FullName = $"{e.FirstName} {e.LastName}",
                e.EmployeeId
                }), 
                "EmployeeId", "FullName"
                );
            return Page();
        }

        [BindProperty]
        public Employee Employee { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Employees == null || Employee == null)
            {
                return Page();
            }

            _context.Employees.Add(Employee);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
