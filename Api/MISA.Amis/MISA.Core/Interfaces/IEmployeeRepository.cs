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
        /// <summary>
        /// Lấy số bản ghi của bảng nhân viên
        /// </summary>
        /// <returns>Số bản ghi</returns>
        /// CreatedBy: NKTrung (16/04/2021)
        int GetCountEmPloyees();

        /// <summary>
        /// Tìm kiếm nhân viên theo mã hoặc tên
        /// </summary>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: NKTrung (16/04/2021)
        IEnumerable<Employee> SearchEmployeesByEmployeeCodeOrEmployeeName(string keyWord);
    }
}
