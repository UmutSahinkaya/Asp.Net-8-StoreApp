using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
    }
}
