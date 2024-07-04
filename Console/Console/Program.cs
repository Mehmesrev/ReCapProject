using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DeleteCarTest();
            //DeleteBrandTest();
            //AddBrandTest();
            //AddCarTest();

        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car newCar = new Car()
            {
                BrandId = 4,
                ColorId = 1,
                ModelYear = 2024,
                DailyPrice = 1000,
                Description = "Wir produzieren Technologie, andere wenden sie an"
            };
            carManager.Add(newCar);
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand newBrand = new Brand()
            {
                Name = "Mesrewagen"
            };
            brandManager.Add(newBrand);
        }

        private static void DeleteBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand oldBrand = new Brand()
            {
                Id = 1
            };
            brandManager.Delete(oldBrand);
        }

        static void DeleteCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car oldCar = new Car
            {
                Id = 7
            };
            carManager.Delete(oldCar);
        }
    }
}