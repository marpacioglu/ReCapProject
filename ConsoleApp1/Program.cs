using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using Entities;
using System;

namespace ConsoleApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            CarDetailTest();
        }
        private static void CarTest()
        {
            CarServiceManager carManager = new CarServiceManager(new EfCarDal());
            var result = carManager.GetAll();
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Araba Rengi=" + item.ColorId+"Tanım="+item.Description);

            //}
            carManager.Add(new Car { Name = "Jetta", ColorId = 4, BrandId = 4, Description = "deneme5", DailyPrice = 225000, ModelYear = 2020 });
            var result2 = carManager.GetAll();
            foreach (var item in result2)
            {
                Console.WriteLine("Araba Rengi" + item.ColorId + "Tanım=" + item.Description);

            }
            var reslut3= carManager.GetCarsByColorId(1);
            foreach (var item in reslut3)
            {
                Console.WriteLine("Id si 1 olan arabalar " + item.Description);
            }
            //carManager.Delete(Car car);
            //foreach (var item in result)
            //{
            //    Console.WriteLine("Araba Rengi" + item.ColorId + "Tanım=" + item.Description);

            //}
        }
        private static void ColorTest()
        {
            ColorServiceManager colorManager = new ColorServiceManager(new EfColorDal());
            //colorManager.Add(new Color { ColorName = "Sarı" });
            //colorManager.Delete(new Color { Id = 3 });
            colorManager.Update(new Color { Id = 2, ColorName = "Gri" });
            var result1 = colorManager.GetAll();
            foreach (var item in result1)
            {
                Console.WriteLine("Renk:" + item.ColorName);


            }
            var result2 = colorManager.GetById(2);
            foreach (var item in result2)
            {
                Console.WriteLine("Idsi 2 olan renk" + item.ColorName);
            }
            

        }
        private static void BranTest()
        {
            BrandServiceManager bsm = new BrandServiceManager(new EfBrandDal());
            bsm.Add(new Brand { BrandName = "Renault" });
            bsm.Add(new Brand { BrandName = "Mercedes" });
            var result = bsm.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine("Marka:" + item.BrandName);
            }
        }
        private static void CarDetailTest()
        {
            CarServiceManager carser = new CarServiceManager(new EfCarDal());
            var result = carser.GetCarDetails();
            foreach (var item in result)
            {
                Console.WriteLine("Araba Adı:" + item.CarName + "Araba Markası:" + item.BrandName+ "Araba Rengi:" + item.ColorName + "Araba Ücreti:" + item.DailyPrice);
            }
        }
    }
}
