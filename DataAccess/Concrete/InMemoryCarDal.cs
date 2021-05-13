using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,ColorId=2,BrandId=2,ModelYear=2020,Description="Deneme1",DailyPrice=120000},
                new Car{Id=2,ColorId=3,BrandId=3,ModelYear=2021,Description="Deneme2",DailyPrice=250000},
                new Car{Id=3,ColorId=1,BrandId=3,ModelYear=2019,Description="Deneme3",DailyPrice=125000},
                new Car{Id=4,ColorId=5,BrandId=1,ModelYear=2018,Description="Deneme4",DailyPrice=350000},


            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(int id)
        {
            Car carDelete = _car.SingleOrDefault(x => x.Id == id);
            _car.Remove(carDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(x => x.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _car.SingleOrDefault(x => x.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
