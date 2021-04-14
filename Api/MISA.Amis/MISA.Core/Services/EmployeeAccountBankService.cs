using MISA.Core.Entities;
using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class EmployeeAccountBankService:BaseService<EmployeeAccountBank>
    {
        public EmployeeAccountBankService(IBaseRepository<EmployeeAccountBank> baseRepository) : base(baseRepository)
        {

        }
    }
}
