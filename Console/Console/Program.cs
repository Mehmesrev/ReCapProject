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

            //UpdateCarTest();
            //UpdateBrandTest();
            //UpgradeColorTest();

            //GetCarTest();
            //GetBrandTest();
            //GetColorTest();

            //GetAllCarTest();
            //GetAllBrandTest();
            //GetAllColorTest();
        }

        private static void GetAllColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var gaColor in colorManager.GetAll())
            {
                Console.WriteLine(gaColor.Name);
            }
        }

        private static void GetAllBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var gaBrand in brandManager.GetAll())
            {
                Console.WriteLine(gaBrand.Name);
            }
        }

        private static void GetAllCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var gaCar in carManager.GetAll())
            {
                Console.WriteLine(gaCar.Description);
            }
        }

        //Get Mothods 
        private static void GetColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color getColor = new Color();
            getColor = colorManager.Get(1);
            Console.WriteLine(getColor.Name);
        }

        private static void GetBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand getBrand = new Brand();
            getBrand = brandManager.Get(5);
            Console.WriteLine(getBrand.Name);
        }

        private static void GetCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car getCar = new Car();
            getCar = carManager.Get(10);
            Console.WriteLine(getCar.ModelYear + " " + getCar.DailyPrice + " " + getCar.Description);
        }

        //upgrade methods
        private static void UpgradeColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color upgColor = new Color() { Id = 1, Name = "Silver" };
            colorManager.Update(upgColor);
        }

        private static void UpdateBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand updBrand = new Brand() { Id = 4, Name = "Mercesrev" };
            brandManager.Update(updBrand);
        }

        private static void UpdateCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car upgCar = new Car()
            {
                Id = 9, //update, Id'ye bağlı şekilde metodu uygular. 
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
                BrandId = 5,
                ColorId = 2,
                ModelYear = 2005,
                DailyPrice = 200,
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
            Car delCar = new Car
            {
                Id = 7 //delete, Id'ye bağlı şekilde metodu uygular. 
            };
            carManager.Delete(delCar);
        }
    }
}