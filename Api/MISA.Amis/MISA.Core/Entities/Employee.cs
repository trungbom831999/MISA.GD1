using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Thông tin nhân viên
    /// CreatedBy: NKTrung (13/04/2021)
    /// </summary>
    public class Employee : BaseEntity
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeId { get; set; }

        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }

        /// <summary>
        /// Họ tên nhân viên
        /// </summary>
        public string EmployeeName { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính:
        /// 0-nam; 1-nữ; 2-khác
        /// </summary>
        public int? Gender { get; set; }

        /// <summary>
        /// Khóa ngoại (FK)
        /// Id của đơn vị nhân viên
        /// </summary>
        public int EmployeeDepartmentId { get; set; }

        /// <summary>
        /// Số chứng minh thư nhân dân/ thẻ căn cước công dân
        /// </summary>
        public string IdentityNumber { get; set; }

        /// <summary>
        /// Ngày cấp CMTND/ thẻ căn cước công dân
        /// </summary>
        public DateTime? IdentityDate { get; set; }

        /// <summary>
        /// Nơi cấp CMTND/ thẻ căn cước công dân
        /// </summary>
        public string IdentityPlace { get; set; }

        /// <summary>
        /// Chức danh nhân viên
        /// </summary>
        public string EmployeePosition { get; set; }

        /// <summary>
        /// Địa chỉ nhân viên
        /// </summary>
        public string EmployeeAdress { get; set; }

        /// <summary>
        /// số điện thoại di động
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// số điện thoại cố định
        /// </summary>
        public string TeleNumber { get; set; }

        /// <summary>
        /// email nhân viên
        /// </summary>
        public string Email { get; set; }
    }
}
