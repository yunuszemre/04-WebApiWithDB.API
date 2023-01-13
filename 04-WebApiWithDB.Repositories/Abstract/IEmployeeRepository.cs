using _04_WebApiWithDB.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Repositories.Abstract
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmpleyees();
        
        Task<Employee> GetEmployeeById(int id);

        List<Employee> GeEmployeeByDepartment(string department);

        Employee CreateEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);

        Employee DeleteEmployee(int id);    
    }
}
