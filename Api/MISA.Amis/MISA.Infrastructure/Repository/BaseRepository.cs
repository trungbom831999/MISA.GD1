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
            //var offset = 0;
            //var limmit = 20;
            var storeName = $"Proc_Get{_tableName}s";
            //var entities = _dbConnection.Query<MISAEntity>(storeName, new { offset = 0, limmit = 20 }, commandType: CommandType.StoredProcedure);
            var entities = _dbConnection.Query<MISAEntity>(storeName, commandType: CommandType.StoredProcedure);
            return entities;
        }

        public MISAEntity GetById(Guid entityId)
        {
            // Thực hiện lấy dữ liệu từ Database:
            var storeName = $"Proc_Get{_tableName}ById";
            DynamicParameters dynamicParameters = new DynamicParameters();
            var storeGetByIdInputParamName = $"@{_tableName}Id";
            dynamicParameters.Add(storeGetByIdInputParamName, entityId);

            var entity = _dbConnection.Query<MISAEntity>(storeName, param: dynamicParameters, commandType: CommandType.StoredProcedure).FirstOrDefault();
            return entity;
        }

        public int Insert(MISAEntity entity)
        {
            // Thực hiện lấy dữ liệu từ Database:
            var storeName = $"Proc_Insert{_tableName}";
            //truyền các param của phần tử
            var storeParam = entity;
            var rowAffects = _dbConnection.Execute(storeName, param: storeParam, commandType: CommandType.StoredProcedure);
            return rowAffects;
            //throw new NotImplementedException();
        }

        public int Update(MISAEntity entity, Guid entityId)
        {
            //var storeName = $"Proc_Update{_tableName}";
            //var storeParam = entity;
            //var rowAffects = _dbConnection.Execute(storeName, param: storeParam, commandType: CommandType.StoredProcedure);
            //return rowAffects;
            throw new NotImplementedException();
        }

        public int Delete(Guid entityId)
        {
            //var storeParam = new
            //{
            //    CustomerId = entityId
            //};
            //var rowEffects = _dbConnection.Execute($"Proc_Delete{_tableName}By{_tableName}Id", param: storeParam, commandType: CommandType.StoredProcedure);
            //return rowEffects;
            throw new NotImplementedException();
        }

    }
}
