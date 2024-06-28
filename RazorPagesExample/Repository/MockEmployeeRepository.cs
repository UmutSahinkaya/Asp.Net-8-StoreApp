using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository(List<Employee> employeeList)
        {
            _employeeList = new List<Employee>()
            {
                new Employee{Id=1, Name="Ahmet",Email="Def@def.com",Photo="1.jpg",Department="Muhasebe"},
                new Employee{Id=2, Name="Ali",Email="Ali@def.com",Photo="2.jpg",Department="Arge"},
                new Employee{Id=3, Name="Veli",Email="Veli@def.com",Photo="3.jpg",Department="Ürge"},
                new Employee{Id=4, Name="Görkem",Email="Görkem@def.com",Photo="4.jpg",Department="IK"},
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }
    }
}
