﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDao
    {
        List<Car> GetAll();

        void GetById(Car car);
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
    }
}

    
