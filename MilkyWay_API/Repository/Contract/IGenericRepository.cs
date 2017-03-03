using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkyWay_API
{
    internal interface IGenericRepository<TEntity> where TEntity:class
    {
        TEntity Get(int Id);

        IEnumerable<TEntity> GetAll();
        bool Add(TEntity obj);
        bool Delete(int Id);
        bool Update(int Id); 
        List<TEntity> GetByParams(TEntity obj);
    }
}
