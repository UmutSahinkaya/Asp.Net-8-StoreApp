using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesExample.Models;
using RazorPagesExample.Repository;

namespace RazorPagesExample.Pages.Employees
{
    public class EditModel : PageModel
    {
        public Employee Employee { get; set; } = null!;
        private readonly IEmployeeRepository _employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void OnGet(int id)
        {
            Employee=_employeeRepository.GetById(id);
        }
        public void OnPost(int id)
        {
            Employee = _employeeRepository.GetById(id);
        }
    }
}
