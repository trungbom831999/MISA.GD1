using MISA.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.Core.Services
{
    public class BaseService<MISAEntity> : IBaseService<MISAEntity>
    {
        public IEnumerable<MISAEntity> GetEntities()
        {
            throw new NotImplementedException();
        }

        public MISAEntity GetById(Guid entityId)
        {
            throw new NotImplementedException();
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
