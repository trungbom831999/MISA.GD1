using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Entities
{
    /// <summary>
    /// Đơn vị nhân viên
    /// CreatedBy: NKTrung (13/04/2021)
    /// </summary>
    public class Department : BaseEntity
    {
        /// <summary>
        /// Khóa chính
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// tên đơn vị
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// mô tả bộ phận
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// trách nhiệm đơn vị
        /// </summary>
        public string Response { get; set; }

        /// <summary>
        /// quyền lợi của đơn vị
        /// </summary>
        public string Profit { get; set; }
    }
}
