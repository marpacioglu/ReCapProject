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
    public class EfColorDal : IColorDal
    {
        RecapCarContext context = new RecapCarContext();
        public void Add(Color entity)
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }

        public void Delete(Color entity)
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            return context.Set<Color>().SingleOrDefault(filter);
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
        }

        public List<Color> GetById(int id)
        {
            return context.Set<Color>().Where(c => c.Id == id).ToList();
        }

        public void Update(Color entity)
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
