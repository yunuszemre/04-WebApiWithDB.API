using _04_WebApiWithDB.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Service.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmpleyees();

        Task<Employee> GetEmployeeById(int id);

        List<Employee> GetEmployeeByDepartment(string department);

        Employee CreateEmployee(Employee employee);

        Employee UpdateEmployee(Employee employee);

        void DeleteEmployee(int id);
    }
}
