﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

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
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Fiyat 0 dan büyük olmalı");
            }
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }


        public List<Car> GetCarsByBranId(int id)
        {
            return _carDal.GetAll(p => p.BrandId==id);
        }

        

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }
    }
}
