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
            _carDao =carDao ;
        }
        public List<Car> GetAll()
        {
            return _carDao.GetAll();
        }
    }
}
