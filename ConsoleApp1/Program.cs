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
            CarTest();
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
    }
}
