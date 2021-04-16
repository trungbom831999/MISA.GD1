using MISA.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    /// chứa 1 số hàm chi tiết cho nhân viên (check trùng mã,...)
    public interface IEmployeeRepository : IBaseRepository<Employee>
    {
        bool CheckEmployeeCode(string employeeCode);
    }
}
