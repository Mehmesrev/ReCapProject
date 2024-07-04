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
            //DeleteColorTest();
            //AddCarTest();
            //AddBrandTest();
            //AddColorTest();
            CarManager carManager = new CarManager(new EfCarDal());
            Car upgCar = new Car() 
            {
                BrandId = 4,
                ColorId = 1,
                ModelYear = 2023,
                DailyPrice = 100,
                Description = "4x4 kaplan arazi aracı"
            };
            carManager.Update(upgCar);

        }

        //add methods
        private static void AddColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color addColor = new Color() { Name = "Gray" };
            colorManager.Add(addColor);
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand addBrand = new Brand() { Name = "Mesrewagen" };
            brandManager.Add(addBrand);
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car addCar = new Car()
            {
                BrandId = 4,
                ColorId = 1,
                ModelYear = 2024,
                DailyPrice = 1000,
                Description = "Wir produzieren Technologie, andere wenden sie an"
            };
            carManager.Add(addCar);
        }

        //delete methods
        private static void DeleteColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color delColor = new Color() { Id = 2 };
            colorManager.Delete(delColor);
        }

        private static void DeleteBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand delBrand = new Brand() { Id = 1 };
            brandManager.Delete(delBrand);
        }

        static void DeleteCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car delCar = new Car { Id = 7 };
            carManager.Delete(delCar);
        }
    }
}