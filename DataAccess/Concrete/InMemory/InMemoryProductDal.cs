using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId =1, CategoryId=1, ColorId=1, DailyPrice=390000, Description = "Chevrolet Sedan", ModelYear = 2010},
                new Car{Id=2, BrandId =1, CategoryId=1, ColorId=2, DailyPrice=480000, Description = "Chevrolet Cruze 1.6 LT Plus", ModelYear = 2012},
                new Car{Id=3, BrandId =2, CategoryId=1, ColorId=1, DailyPrice=95000, Description = "Tofaş Şahin", ModelYear = 2009}
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carsToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(car);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById()
        {
            return _cars.Where(c => c.Id == c.Id && c.CategoryId == c.CategoryId).ToList();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;
            carsToUpdate.ModelYear = car.ModelYear;
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.CategoryId = car.CategoryId;
        }
    }
}
