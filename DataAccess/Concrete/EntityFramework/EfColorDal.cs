using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color color)
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                var addedEntity = context.Entry(color);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color color)
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                var deletedEntity = context.Entry(color);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void Update(Color color)
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                var updatedEntity = context.Entry(color);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                return filter == null
                    ? context.Set<Color>().ToList()
                    : context.Set<Color>().Where(filter).ToList();
            }
        }
    }
}
