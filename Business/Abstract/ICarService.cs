using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
  public interface ICarService
    {

        IResult Add(Car car);

        IResult Update(Car car);

        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();

        IDataResult<Car> GetById(int carId);

        IDataResult<List<Car>> GetAllCarsByBranId(int brandId);

        IDataResult<List<Car>> GetAllCarsByColorId(int brandId);

        IDataResult<List<DailyPriceDto>> GetDailyPrice();


    }
}
