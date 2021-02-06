using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDao _carDao;

        public CarManager(ICarDao carDao)
        {
            _carDao = carDao;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDao.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }

        public void Delete(Car car)
        {
            _carDao.Delete(car);
            Console.WriteLine("Araba başarıyla silindi.");

        }

        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDao.GetAll(c => c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDao.GetAll(c => c.ColorId == id);

        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDao.GetAll(c => c.DailyPrice >= min && c.DailyPrice <= max);

        }

        public Car GetById(int id)
        {
            return _carDao.Get(c => c.CarId == id);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDao.GetAll(c => c.ModelYear.Contains(year) == true);
        }

        public void Update(Car car)
        {
            if (car.DailyPrice > 0)
            {
                _carDao.Update(car);
                Console.WriteLine("Araba başarıyla güncellendi.");
            }
            else
            {
                Console.WriteLine($"Lütfen günlük fiyat kısmını 0'dan büyük giriniz. Girdiğiniz değer : {car.DailyPrice}");
            }
        }
    }
}