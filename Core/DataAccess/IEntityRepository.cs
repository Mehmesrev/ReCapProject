using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //generic constraint
        //class: referans tip
        //IEntity: IEntity olabilir veya IEntity implemente eden bir object olabilir.
        //new(): sadece IEntity implemente eden bir object olabilir.
        List<T> GetAll(Expression<Func<T, bool>> fiter = null);
        T Get(Expression<Func<T, bool>> fiter);
        void Add(T entity); //default public
        void Update(T entity); //default public
        void Delete(T entity); //default public
        
    }
}
