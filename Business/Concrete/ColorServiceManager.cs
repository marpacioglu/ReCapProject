using Business.Abstract;
using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
   public class ColorServiceManager : IColorService
    {
        IColorDal _colorDal;

        public ColorServiceManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            _colorDal.Add(color);

        }

        public void Delete(Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Color> GetAll()
        {
          return  _colorDal.GetAll();

        }

        public List<Color> GetById(int id)
        {
            return _colorDal.GetById(id);
        }

        public void Update(Color color)
        {
            _colorDal.Update(color);

        }
    }
}
