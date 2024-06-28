using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesExample.Pages.Employees
{
    public class IndexModel : PageModel
    {
        public string Message { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "Merhabalar.";
        }
    }
}
