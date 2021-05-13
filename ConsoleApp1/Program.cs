using Business.Concrete;
using DataAccess.Concrete;
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
            CarServiceManager carManager = new CarServiceManager(new InMemoryCarDal());
            var result = carManager.GetAll();
            foreach (var item in result)
            {
                Console.WriteLine("Araba Rengi=" + item.ColorId+"Tanım="+item.Description);

            }
            carManager.Add(new Car { Id = 5, ColorId = 4, BrandId = 4, Description = "deneme5", DailyPrice = 225000, ModelYear = 2020 });
            foreach (var item in result)
            {
                Console.WriteLine("Araba Rengi" + item.ColorId+"Tanım="+item.Description);

            }
            carManager.Delete(2);
            foreach (var item in result)
            {
                Console.WriteLine("Araba Rengi" + item.ColorId + "Tanım=" + item.Description);

            }
        }
    }
}
