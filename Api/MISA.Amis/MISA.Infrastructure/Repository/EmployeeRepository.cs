using Dapper;
using MISA.Core.Entities;
using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Repository
{
    public class EmployeeRepository : BaseRepository<Employee>, IEmployeeRepository
    {
        public int GetCountEmPloyees()
        {
            var storeName = $"Proc_GetCount{_tableName}s";
            //var entities = _dbConnection.Query<MISAEntity>(storeName, new { offset = 0, limmit = 20 }, commandType: CommandType.StoredProcedure);
            int count = (int)(long)_dbConnection.ExecuteScalar(storeName, commandType: CommandType.StoredProcedure);
            return count;
        }
    }
}
