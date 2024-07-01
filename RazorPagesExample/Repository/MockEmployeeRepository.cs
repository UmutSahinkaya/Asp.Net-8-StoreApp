using RazorPagesExample.Models;

namespace RazorPagesExample.Repository
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee{Id=1, Name="Ayşe",Email="Def@def.com",Photo="1.jpg",Department="Muhasebe"},
                new Employee{Id=2, Name="Ali",Email="Ali@def.com",Photo="2.jpg",Department="Arge"},
                new Employee{Id=3, Name="Veli",Email="Veli@def.com",Photo="3.jpg",Department="Ürge"},
                new Employee{Id=4, Name="Görkem",Email="Görkem@def.com",Photo="4.jpg",Department="IK"},
            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return _employeeList;
        }

        public Employee GetById(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee entity)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == entity.Id);
            if(employee != null)
            {
                employee.Name= entity.Name;
                employee.Email= entity.Email;
                employee.Photo= entity.Photo;
                employee.Department= entity.Department;
            }
            return employee;
        }
    }
}
