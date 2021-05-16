using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public  interface IEntityRepository<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);//detaylı filtreleme de yapabilmek için(ayrı ayrı sorgu yazmaya gerek kalmıyor)
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
