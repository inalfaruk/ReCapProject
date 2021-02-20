using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentaCarContext>, IRentalDal
    {
        public RentalDetailDto RentControl(int carId)
        {
            using (RentaCarContext context = new RentaCarContext())
            {
                var result =  from r in context.Rentals where r.CarId == carId orderby r.ReturnDate descending
                               join car in context.Cars on r.CarId equals car.Id
                               join b in context.Brands on car.BrandId equals b.Id
                               join cl in context.Colors on car.ColorId equals cl.Id
                               join c in context.Customers on r.CustomerId equals c.Id
                               join u in context.Users on c.UserId equals u.Id

                               select new RentalDetailDto
                               {
                                   CarName = car.CarName,
                                   BrandName = b.BrandName,
                                   ColorName = cl.ColorName,
                                   ModelYear = car.ModelYear,
                                   DailyPrice = car.DailyPrice,
                                   FirstName = u.FirstName,
                                   LastName = u.LastName,
                                   CompanyName = c.CompanyName,
                                   RentDate = r.RentDate,
                                   ReturnDate = r.ReturnDate
                                  
                               };
                
                return result.First();
            }
        }

        public List<RentalDetailDto> GetRentList()
        {
            using (RentaCarContext context =new RentaCarContext())

            {
                var result = from r in context.Rentals
                             join car in context.Cars on r.CarId equals car.Id
                             join b in context.Brands on car.BrandId equals b.Id
                             join cl in context.Colors on car.ColorId equals cl.Id
                             join c in context.Customers on r.CustomerId equals c.Id
                             join u in context.Users on c.UserId equals u.Id

                             select new RentalDetailDto {
                                 CarName = car.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cl.ColorName,
                                 ModelYear= car.ModelYear,
                                 DailyPrice=car.DailyPrice,
                                 FirstName=u.FirstName,
                                 LastName=u.LastName,
                                 CompanyName=c.CompanyName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate
                             };
                return result.ToList();

                
            }        


        }

       
    }
    
}
