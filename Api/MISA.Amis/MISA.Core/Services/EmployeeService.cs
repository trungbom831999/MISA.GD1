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
        public EmployeeService(IBaseRepository<Employee> baseRepository) : base(baseRepository)
        {

        }
    }
}
