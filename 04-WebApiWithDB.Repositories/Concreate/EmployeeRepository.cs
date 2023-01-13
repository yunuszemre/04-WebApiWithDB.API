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
        public List<Employee> GetEmployeeByDepartment(string department)
        {

            return _context.Employees.Where(t0 => t0.Department == department).ToList();
        }

        public List<Employee> GetAllEmpleyees()
        {
            return _context.Employees.ToList();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.Employees.FindAsync(id);
        }
        public Employee CreateEmployee(Employee employee)
        {
            _context.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteEmployee(int id)
        {
            Employee deletedUser = _context.Employees.FirstOrDefault(t0 => t0.Id == id);

            _context.Remove(deletedUser);
            _context.SaveChanges();
            
        }



        public Employee UpdateEmployee(Employee employee)
        {
            _context.Update(employee);
            _context.SaveChanges();
            return employee;
        }
    }
}
