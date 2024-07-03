using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, VsCarProjectContext>, ICarDal
    {
        public List<CarDetailDto> Add()
        {
            using (VsCarProjectContext context = new VsCarProjectContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.Id equals b.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 Name = b.Name,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
