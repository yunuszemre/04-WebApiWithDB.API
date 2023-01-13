using _04_WebApiWithDB.Entities.Concreate;
using _04_WebApiWithDB.Repositories.Abstract;
using _04_WebApiWithDB.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_WebApiWithDB.Service.Concreate
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }
        public List<Employee> GetEmployeeByDepartment(string department)
        {

            if (department != null)
                return _employeeRepository.GetEmployeeByDepartment(department).ToList();
            else
                throw new Exception("Departmen bilgisini giriniz");
        }

        public List<Employee> GetAllEmpleyees()
        {
            if (_employeeRepository.GetAllEmpleyees().Any())
                return _employeeRepository.GetAllEmpleyees();
            else
                throw new Exception("Veritabanında herhangi bir employee bulunamadı");

        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            if (id != 0 && id != null)
                return await _employeeRepository.GetEmployeeById(id);
            else
                throw new Exception("Id bilgisi 0 ve boş olmamalıdır");
        }
        public Employee CreateEmployee(Employee employee)
        {
            if (employee != null)
                return _employeeRepository.CreateEmployee(employee);
            else
                throw new Exception("Employee boş olamaz!");
        }

        public void DeleteEmployee(int id)
        {
            if (id > 0)
                _employeeRepository.DeleteEmployee(id);
            else
                throw new Exception("Id bilgisi 0 dan büyük olmalıdır");

        }

        public Employee UpdateEmployee(Employee employee)
        {
            if (employee != null)
                return _employeeRepository.UpdateEmployee(employee);
            else throw new Exception("Employee boş olamaz");
        }
    }
}
