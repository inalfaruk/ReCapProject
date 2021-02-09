using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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
                Console.WriteLine("Araç Eklendi." + car.Description);
            }
            else
            {
                Console.WriteLine("Fiyat 0 dan büyük olmalı");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Color> GetById()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBranId(int id)
        {
            return _carDal.GetAll(p => p.BrandId==id);
        }

        

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(p => p.ColorId == id);
        }

        public List<DailyPriceDto> GetDailyPrice()
        {
            return _carDal.GetDailyPrice();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }

    }
}
