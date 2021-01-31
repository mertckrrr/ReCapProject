using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDao:ICarDao
    {
        List<Car> _cars;
        public InMemoryCarDao()
        {
            _cars = new List<Car> { 
                new Car {CarId=1200,BrandId="Opel",ColorId=1,DailyPrice=150000,Description="Hızlı,Dinamik Alman Arabası",ModelYear=2017},
                new Car {CarId=1201,BrandId="Mercedes",ColorId=1,DailyPrice=200000,Description="En Konforlu Alman Arabası",ModelYear=2021},
                new Car {CarId=1202,BrandId="BMW",ColorId=2,DailyPrice=175000,Description="En Hızlı Alman Arabası",ModelYear=2020},
                new Car {CarId=1203,BrandId="Peugeot",ColorId=2,DailyPrice=150000,Description="Hızlı,Dinamik Fransız Arabası",ModelYear=2018},
                new Car {CarId=1204,BrandId="Audi",ColorId=3,DailyPrice=165000,Description="Hızlı Alman Arabası",ModelYear=2020},

            };

        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car productToDelete = _cars.SingleOrDefault(c => c.CarId == c.CarId);


            _cars.Remove(productToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.CarId == CarId).ToList();
        }

        public void GetById(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == c.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CarId = car.CarId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
        }
    }
}
