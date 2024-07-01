using System;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Abstract;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICarDal carDal = new EfCarDal();
            CarManager carManager = new CarManager(carDal);

            // Yeni bir araç ekleme
            try
            {
                Car newCar = new Car
                {
                    BrandId = 1, // Mevcut bir brandId kullanmalısınız
                    ColorId = 1, // Mevcut bir colorId kullanmalısınız
                    DailyPrice = 150,
                    Description = "BMW"
                };

                carManager.Add(newCar);
                Console.WriteLine("Car added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
            }

            // Tüm araçları listeleme
            try
            {
                foreach (var car in carManager.GetAll())
                {
                    Console.WriteLine($"Car Id: {car.Id}, Description: {car.Description}, BrandId: {car.BrandId}, ColorId: {car.ColorId}, DailyPrice: {car.DailyPrice}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    
    }
}