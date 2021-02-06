using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDao _colorDao;

        public ColorManager(IColorDao brandDao)
        {
            _colorDao = brandDao;
        }

        public void Add(Color entity)
        {
            _colorDao.Add(entity);
        }

        public void Delete(Color color)
        {
            _colorDao.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _colorDao.GetAll();

        }

        public Color GetById(int id)
        {
            return _colorDao.Get(c => c.ColorId == id);
        }

        public void Update(Color entity)
        {
            _colorDao.Update(entity);
        }
    }
}