using Dapper;
using MISA.Core.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Repository
{
    public class BaseRepository<MISAEntity> : IBaseRepository<MISAEntity>
    {
        //Kết nối DB
        protected string _tableName = string.Empty;
        protected string _connectionString = "" +
               "Host=47.241.69.179; " +
               "Port=3306;" +
               "User Id= dev; " +
               "Password=12345678;" +
               "Database= MF777_NKTrung_AMIS;" +
               "convert zero datetime=True;";
        protected IDbConnection _dbConnection;

        public BaseRepository()
        {
            _tableName = typeof(MISAEntity).Name;
            _dbConnection = new MySqlConnection(_connectionString);
        }

        public IEnumerable<MISAEntity> GetEntities()
        {
            // Thực hiện lấy dữ liệu từ Database:
            var storeName = $"Proc_Get{_tableName}";
            var entities = _dbConnection.Query<MISAEntity>($"Proc_Get{_tableName}", commandType: CommandType.StoredProcedure);
            return entities;
        }

        public MISAEntity GetById(Guid entityId)
        {
            // Thực hiện lấy dữ liệu từ Database:
            var storeName = $"Proc_Get{_tableName}By{_tableName}Id";
            DynamicParameters dynamicParameters = new DynamicParameters();
            var storeGetByIdInputParamName = $"@{_tableName}Id";
            dynamicParameters.Add(storeGetByIdInputParamName, entityId);

            var entity = _dbConnection.Query<MISAEntity>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entity;
        }

        public int Insert(MISAEntity entity)
        {
            throw new NotImplementedException();
        }

        public int Update(MISAEntity entity, Guid entityId)
        {
            throw new NotImplementedException();
        }

        public int Delete(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}
