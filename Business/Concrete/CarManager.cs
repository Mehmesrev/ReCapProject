using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            //car.Description: araba ismi yerine kullanıldı 
            if (car.Description.Length < 2)
            {
                throw new Exception("Car name must be at least 2 characters long.");
            }

            if (car.DailyPrice <= 0)
            {
                throw new Exception("Daily price must be greater than 0.");
            }

            _carDal.Add(car);
        }

        public void Update(Car car)
        {
            var carToUpdate = _carDal.Get(c => c.Id == car.Id);

            if (carToUpdate != null)
            {
                carToUpdate.BrandId = car.BrandId;
                carToUpdate.ColorId = car.ColorId;
                carToUpdate.DailyPrice = car.DailyPrice;
                carToUpdate.Description = car.Description;
                _carDal.Update(carToUpdate);
            }
            else
            {
                throw new Exception("Car not found.");
            }
        }

        public void Delete(Car car)
        {
            var carToDelete = _carDal.Get(c => c.Id == car.Id);
            if (carToDelete != null)
            {
                _carDal.Delete(carToDelete);
            }
            else
            {
                throw new Exception("Car not found.");
            }
        }

        public Car Get(Car car)
        {
            var carFromDb = _carDal.Get(c => c.Id == car.Id);
            if (carFromDb != null)
            {
                return carFromDb;
            }
            else
            {
                throw new Exception("Car not found.");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int colorId)
        {
            return _carDal.GetAll(c => c.BrandId == colorId);
        }

        public List<Car> GetCarsByColorId(int brandId)
        {
            return _carDal.GetAll(c => c.BrandId == brandId);
        }
    }
}
