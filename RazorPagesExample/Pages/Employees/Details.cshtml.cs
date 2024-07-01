using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;

namespace RazorPagesExample.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        public Employee Employee { get; set; } = default!;
        private readonly IEmployeeRepository _employeeRepository;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IActionResult OnGet(int id)
        {
            Employee=_employeeRepository.GetById(id);
            if (Employee == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
