using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RentaCarContext>, ICarDal
    {
        public List<DailyPriceDto> GetDailyPrice()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join r in context.Colors
                             on c.ColorId equals r.Id

                             select new DailyPriceDto { CarId = c.Id, CarName = c.CarName, BrandName = b.BrandName, ColorName = r.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }       
        }

        public List<CarDetailListDto> GetAllCarDetail()
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             join b in context.Brands
                             on car.BrandId equals b.Id

                             select new CarDetailListDto { Id = car.Id,BrandId=car.BrandId,ColorId=car.ColorId ,CarName = car.CarName, ColorName = c.ColorName, BrandName = b.BrandName, DailyPrice = car.DailyPrice };

                return result.ToList();
            }

        }



        public List<CarDetailListDto> GetCarDetailByBrandId(int brandId)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result = from car in context.Cars where car.BrandId==brandId
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             join b in context.Brands
                             on car.BrandId equals b.Id

                             select new CarDetailListDto { Id = car.Id, BrandId = car.BrandId, ColorId = car.ColorId, CarName = car.CarName, ColorName = c.ColorName, BrandName = b.BrandName, DailyPrice = car.DailyPrice };

                return result.ToList();
            }

        }

    }
}
