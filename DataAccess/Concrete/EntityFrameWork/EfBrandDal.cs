using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfBrandDal : IBrandDal
    {
        RecapCarContext context = new RecapCarContext();
        public void Add(Brand entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Brand entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            return context.Set<Brand>().SingleOrDefault(filter);
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
        }

        public List<Brand> GetById(int id)
        {
            return context.Set<Brand>().Where(c => c.Id == id).ToList();
        }

        public void Update(Brand entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
