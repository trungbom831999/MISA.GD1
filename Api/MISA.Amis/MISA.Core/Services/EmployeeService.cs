using MISA.Core.Entities;
using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class EmployeeService : BaseService<Employee>, IEmployeeService 
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository, IBaseRepository<Employee> baseRepository) : base(baseRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public int GetCountEmPloyees()
        {
            return _employeeRepository.GetCountEmPloyees();
        }

        public IEnumerable<Employee> SearchEmployeesByEmployeeCodeOrEmployeeName(string keyWord)
        {
            return _employeeRepository.SearchEmployeesByEmployeeCodeOrEmployeeName(keyWord);
        }
    }
}
