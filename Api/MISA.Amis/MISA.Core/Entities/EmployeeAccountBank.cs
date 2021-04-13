using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Tài khoản ngân hàng của nhân viên
    /// CreatedBy: NKTrung (13/04/2021)
    /// </summary>
    public class EmployeeAccountBank : BaseEntity
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid EmployeeAccountId { get; set; }

        /// <summary>
        /// số tài khoản ngân hàng của nhân viên
        /// </summary>
        public string EmployeeAccountNumber { get; set; }

        /// <summary>
        /// tên ngân hàng
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// tên chi nhánh
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// tỉnh/tp của ngân hàng
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Khóa ngoại (FK)
        /// Id của nhân viên có só tài khoản này
        /// </summary>
        public Guid? EmployeeId { get; set; }

        /// <summary>
        /// trạng thái tài khoản ngân hàng:
        /// 0-ngưng sử dụng; 1-sử dụng
        /// </summary>
        public int StateAccount { get; set; }
    }
}
