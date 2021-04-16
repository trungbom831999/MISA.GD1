using Dapper;
using Microsoft.AspNetCore.Mvc;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using MISA.CukCuk.Api.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Amis.Api.Controllers
{
    /// <summary>
    /// Api cho đối tượng Nhân viên
    /// </summary>
    public class EmployeeController : BaseEntityController<Employee>
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService) : base(employeeService)
        {
            _employeeService = employeeService;
        }

        /// <summary>
        /// Thêm mới
        /// </summary>
        /// <param name="entity">Khách hàng muốn thêm mới</param>
        /// <returns>
        ///  - HttpCode: 200 nếu thêm được dữ liệu
        ///  - Lỗi dữ liệu không hợp lệ : 400 (BadRequest)
        ///  - HttpCode: 500 nếu có lỗi hoặc Exception xảy ra trên Server
        /// </returns>
        /// CreatedBy: NKTrung (13/04/2021)
        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            // Check Mã nhân viên trùng:
            var sqlCheckExitCode = $"Select EmployeeCode from Employee Where EmployeeCode = @EmployeeCode";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@EmployeeCode", employee.EmployeeCode);
            var employeeExitsCode = _dbConnection.Query<string>(sqlCheckExitCode, dynamicParameters);
            if (employeeExitsCode.Count() > 0)
            {
                var erroInfo = new
                {
                    devMsg = "EmployeeCode duplucate!",
                    userMsg = "Thông tin Mã nhân viên đã tồn tại",
                    errorCode = "misa-001",
                    moreInfo = "https://openapi.misa.com.vn/errorcode/misa-001",
                    traceId = "ba9587fd-1a79-4ac5-a0ca-2c9f74dfd3fb"
                };

                return BadRequest(erroInfo);
            }

            // Thực hiện lấy dữ liệu từ Database:
            var rowAffects = _employeeService.Insert(employee);
            // Kiểm tra kết quả và trả về cho Client:
            if (rowAffects == 0)
                return NoContent();
            else
                return Ok(employee);
        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="entity">Khách hàng muốn thêm mới</param>
        /// <returns>
        ///  - HttpCode: 200 nếu thêm được dữ liệu
        ///  - Lỗi dữ liệu không hợp lệ : 400 (BadRequest)
        ///  - HttpCode: 500 nếu có lỗi hoặc Exception xảy ra trên Server
        /// </returns>
        /// CreatedBy: NKTrung (13/04/2021)
        [HttpPut("{entityId}")]
        public IActionResult Put(Employee employee, Guid employeeId)
        {
            // Check Mã nhân viên trùng:
            var sqlCheckExitCode = $"Select EmployeeCode from Employee Where EmployeeCode = @EmployeeCode AND EmployeeId <> '{employeeId}'";
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@EmployeeCode", employee.EmployeeCode);
            var employeeExitsCode = _dbConnection.Query<string>(sqlCheckExitCode, dynamicParameters);
            if (employeeExitsCode.Count() > 0)
            {
                var erroInfo = new
                {
                    devMsg = "EmployeeCode duplucate!",
                    userMsg = "Thông tin Mã nhân viên đã tồn tại",
                    errorCode = "misa-001",
                    moreInfo = "https://openapi.misa.com.vn/errorcode/misa-001",
                    traceId = "ba9587fd-1a79-4ac5-a0ca-2c9f74dfd3fb"
                };

                return BadRequest(erroInfo);
            }

            // Thực hiện lấy dữ liệu từ Database:
            var rowAffects = _employeeService.Update(employee, employeeId);
            // Kiểm tra kết quả và trả về cho Client:
            if (rowAffects == 0)
                return NoContent();
            else
                return Ok(employee);
        }

        /// <summary>
        /// check trùng mã nhân viên
        /// </summary>
        /// <param name="employeeCode">Mã nhân viên cần check</param>
        /// <param name="employeeId">Id của nhân viên</param>
        /// <returns>
        ///  - HttpCode: 400 - BadRequset nếu đã trùng
        ///  - True nếu không trùng
        /// </returns>
        /// CreatedBy: NKTrung (16/04/2021)
        //protected IActionResult CheckDuplucateEmployeeCode(string employeeCode, Guid employeeId)
        //{
        //    var sqlCheckExitCode = $"Select EmployeeCode from Customer Where EmployeeCode = @EmployeeCode AND EmployeeId <> '{employeeId}'";
        //    DynamicParameters dynamicParameters = new DynamicParameters();
        //    dynamicParameters.Add("@CustomerCode", employeeCode);
        //    var customerExitsCode = _dbConnection.Query<string>(sqlCheckExitCode, dynamicParameters);
        //    if (customerExitsCode.Count() > 0)
        //    {
        //        var erroInfo = new
        //        {
        //            devMsg = "EmployeeCode duplucate!",
        //            userMsg = "Thông tin Mã nhân viên đã tồn tại",
        //            errorCode = "misa-001",
        //            moreInfo = "https://openapi.misa.com.vn/errorcode/misa-001",
        //            traceId = "ba9587fd-1a79-4ac5-a0ca-2c9f74dfd3fb"
        //        };

        //        return BadRequest(erroInfo);
        //    }
        //}
    }
}
