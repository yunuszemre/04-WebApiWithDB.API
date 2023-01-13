using _04_WebApiWithDB.Entities.Concreate;
using _04_WebApiWithDB.Repositories.Abstract;
using _04_WebApiWithDB.Repositories.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Repositories.Concreate
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ProjeContext _context;
        public EmployeeRepository(ProjeContext context)
        {
            _context = context;
        }
        public Employee CreateEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GeEmployeeByDepartment(string department)
        {
            
        }

        public List<Employee> GetAllEmpleyees()
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.FindAsync();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
