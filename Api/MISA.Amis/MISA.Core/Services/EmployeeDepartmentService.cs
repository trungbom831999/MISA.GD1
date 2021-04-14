using MISA.Core.Entities;
using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class EmployeeDepartmentService : BaseService<EmployeeAccountBank>
    {
        public EmployeeDepartmentService(IBaseRepository<EmployeeAccountBank> baseRepository) : base(baseRepository)
        {

        }
    }
}
