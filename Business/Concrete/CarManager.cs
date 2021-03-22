using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Bussiness.Constants;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {

          //  ValidationTool.Validate(new CarValidator(), car);


            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araç Eklendi." + car.Description);

                return new SuccessResult(Messages.CarAdded);

            }
            else
            {
              
                return new ErrorResult("Fiyat 0 dan büyük olmalı");
            }
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
     
        public IResult Delete(Car car)
        {
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            // return _carDal.GetAll();

            if (DateTime.Now.Hour==4)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);


        } 

        public IDataResult<List<Car>> GetAllCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId));
        }

        public IDataResult<List<Car>> GetAllCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==brandId));
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p=>p.Id== carId));
        }

        public IDataResult<List<DailyPriceDto>> GetDailyPrice()
        {
            return new SuccessDataResult<List<DailyPriceDto>>(_carDal.GetDailyPrice());
        }
               
        public IDataResult<List<CarDetailListDto>> GetAllCarDetail()
        {
            return new SuccessDataResult<List<CarDetailListDto>>(_carDal.GetAllCarDetail());

        }
           
        public IDataResult<List<CarDetailListDto>> GetCarDetailByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailListDto>>(_carDal.GetCarDetailByBrandId(brandId));
        }

       
    }
}    
