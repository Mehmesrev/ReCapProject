﻿using System;
using Azure.Core;
using Business.Concrete;
using Core.Utilities.Results;
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


            //GetAllCarDetailsTest();

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

        private static void GetAllCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var gct in carManager.GetCarDetails().Data)
                {
                    Console.WriteLine(gct.Id + " " + gct.CarName + " " + gct.BrandName + " " + gct.ColorName + " " + gct.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                foreach (var getAllColor in colorManager.GetAll().Data)
                {
                    Console.WriteLine(getAllColor.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                foreach (var getAllBrand in brandManager.GetAll().Data)
                {
                    Console.WriteLine(getAllBrand.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetAllCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                foreach (var getAllCar in carManager.GetAll().Data)
                {
                    Console.WriteLine(getAllCar.CarName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //Get Mothods 
        private static void GetColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {

                Color getColor = new Color();
                getColor = colorManager.Get(1).Data;
                Console.WriteLine(getColor.ColorName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {

                Brand getBrand = new Brand();
                getBrand = brandManager.Get(5).Data;
                Console.WriteLine(getBrand.BrandName);
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }

        private static void GetCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Car getCar = new Car();
                getCar = carManager.Get(10).Data;
                Console.WriteLine(getCar.ModelYear + " " + getCar.DailyPrice + " " + getCar.Description);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //upgrade methods
        private static void UpgradeColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                Color upgColor = new Color() 
                {
                    Id = 1, ColorName = "Silver"
                };
                colorManager.Update(upgColor);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UpdateBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                Brand updBrand = new Brand()
                {
                    Id = 4,
                    BrandName = "Mercesrev"
                };
                brandManager.Update(updBrand);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void UpdateCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Car upgCar = new Car()
                {
                    Id = 10, //update, Id'ye bağlı şekilde metodu uygular. 
                    BrandId = 4,
                    ColorId = 1,
                    ModelYear = 2024,
                    DailyPrice = 250,
                    Description = "Wir produzieren Technologie, andere wenden sie an",
                    CarName = "Obito"
                };
                carManager.Update(upgCar);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //add methods
        private static void AddColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                Color addColor = new Color()
                {
                    ColorName = "Gray"
                };
                colorManager.Add(addColor);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                Brand addBrand = new Brand()
                {
                    BrandName = "Mesrewagen"
                };
                brandManager.Add(addBrand);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Car addCar = new Car()
                {
                    BrandId = 5,
                    ColorId = 2,
                    ModelYear = 2005,
                    DailyPrice = 200,
                    Description = "Wir produzieren Technologie, andere wenden sie an",
                    CarName = "Mersewagen"
                };
                carManager.Add(addCar);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        //delete methods
        private static void DeleteColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                Color delColor = new Color() { Id = 2 };
                colorManager.Delete(delColor);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DeleteBrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                Brand delBrand = new Brand() { Id = 1 };
                brandManager.Delete(delBrand);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        static void DeleteCarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Car delCar = new Car
                {
                    Id = 7 //delete, Id'ye bağlı şekilde metodu uygular. 
                };
                carManager.Delete(delCar);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}