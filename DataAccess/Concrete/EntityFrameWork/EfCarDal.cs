using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : ICarDal
    {
        RecapCarContext context = new RecapCarContext();
        public void Add(Car entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Car entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            return context.Set<Car>().SingleOrDefault(filter);
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
        }
        

        public List<Car> GetById(int id)
        {
            return context.Set<Car>().Where(c => c.Id == id).ToList();
        }

        public List<CarDTO> GetCarDetails()
        {
            var result = from c in context.Cars
                         join col in context.Colors
                         on c.ColorId equals col.Id
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         select new CarDTO
                         {
                             CarName=c.Name,
                             BrandName=b.BrandName,
                             ColorName=col.ColorName,
                             DailyPrice=c.DailyPrice,
                         };
            return result.ToList();
                       
        }

        public void Update(Car entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
