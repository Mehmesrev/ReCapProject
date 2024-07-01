using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    //generic constraint
    //class: referans tip
    //IEntity: IEntity olabilir veya IEntity implemente eden bir object olabilir.
    //new(): sadece IEntity implemente eden bir object olabilir.
    public interface IEntityRepository<T> where T: class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}