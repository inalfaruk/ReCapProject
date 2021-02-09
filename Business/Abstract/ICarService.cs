using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
  public interface ICarService
    {

        void Add(Car car);

        void Update(Car car);

        void Delete(Car car);

        List<Car> GetAll();

        List<Color> GetById();

        List<Car> GetCarsByBranId(int id);

        List<Car> GetCarsByColorId(int id);

        List<DailyPriceDto> GetDailyPrice();


    }
}
