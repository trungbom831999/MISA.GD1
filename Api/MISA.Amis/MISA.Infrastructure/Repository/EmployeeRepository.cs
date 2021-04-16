using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public bool CheckEmployeeCode(string employeeCode)
        {
            // Validate dữ liệu:
            // - check trùng mã:
            // Kiểm tra xem có khách hàng nào có mã tương tự hay không?:
            var sqlCheckExitCode = "Select EmployeeCode from Employee Where EmployeeCode = @EmployeeCode";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@EmployeeCode", employeeCode);
            var employeeExitsCode = _dbConnection.Query<string>(sqlCheckExitCode, dynamicParameters);
            if (employeeExitsCode.Count() > 0)
            {
                var erroInfo = new
                {
                    devMsg = "CustomerCode duplucate!",
                    userMsg = "Thông tin mã nhân viên đã tồn tại",
                    errorCode = "misa-001",
                    moreInfo = "https://openapi.misa.com.vn/errorcode/misa-001",
                    traceId = "ba9587fd-1a79-4ac5-a0ca-2c9f74dfd3fb"
                };
            }
            return true;
        }
    }
}
