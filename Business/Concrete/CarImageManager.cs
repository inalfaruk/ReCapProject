using Business.Abstract;
using Bussiness.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.IO.Pipes;
using Microsoft.AspNetCore.Http;
using Core.Utilities;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }


        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileHelper.Add(file);
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }
        public IResult Update(IFormFile file, CarImage carImage)
        {
             _carImageDal.Add(carImage);
            return new SuccessResult();
        }
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<CarImage> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(p => p.CarId == carId));
        }

        public IDataResult<CarImage> GetById(int Id)
        {
            throw new NotImplementedException();
        }

       



        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll().Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.CategoryLimitExceeded);
            }

            return new SuccessResult();
        }


        private string CheckIfCarImageNotFound(int carId)
        { 
            
            var result = _carImageDal.GetAll(p => p.CarId == carId).Count;
            if (result <= 0)
            {
                string defaultImage = Environment.CurrentDirectory + @"\wwwroot\images\defaultimage.jpeg";


                 return defaultImage;
            }

            return null;
        }










    }
}
