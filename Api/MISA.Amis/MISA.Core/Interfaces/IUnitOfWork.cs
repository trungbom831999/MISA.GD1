using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employee { get; }
        IDepartmentRepository EmployeeDepartment { get; }
        IEmployeeAccountBankRepository EmployeeAccountBank { get; }
    }
}
