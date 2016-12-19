using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MilkyWay_API.Repository.Implementation
{
    public class GenericRepository<TEntity>: IGenericRepository<TEntity> where TEntity:class
    {

        public TEntity Get(int Id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public bool Update(int Id)
        {
            throw new NotImplementedException();
        }
    }
}