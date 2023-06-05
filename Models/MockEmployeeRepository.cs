using System.Collections.Generic;
using System.Linq;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository:IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>();
            _employeeList.Add(new Employee() { Id = 1, Name = "Diksha", Department = "IT", Email = "diksha@gmail.com" });
            _employeeList.Add(new Employee() { Id = 2, Name = "Becky", Department = "PR", Email = "becky@gmail.com" });
            _employeeList.Add(new Employee() { Id = 3, Name = "Gorizmi", Department = "IT", Email = "gorizmi@gmail.com" });

        }
        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(x => x.Id) + 1;
            _employeeList.Add (employee);
            return employee;
        }
    }
}
