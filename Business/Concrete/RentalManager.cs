using Business.Abstract;
using Bussiness.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {

        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rental)
        {
            _rentalDal = rental;

        }


        public IResult Add(Rental rental,int carId)
        {

          var result = GetRentControl(carId);

            if (result.Data == null)                               // araç daha önce hiç kiralanmamışsa boş tablo döneceğinden kayıt alması için.
            {
                if (rental.RentDate >= DateTime.Now && rental.ReturnDate >= DateTime.Now)
                {
                    _rentalDal.Add(rental);
                    return new SuccessDataResult<Rental>(Messages.RentalAdded);
                }
                else return new ErrorResult(Messages.RentDateError);
              
            }

            else if (result.Data.ReturnDate != null)    //araç geri gelmiş ise yani returndate null değil ise 
            {

               
                if (rental.RentDate >= DateTime.Now && rental.ReturnDate>=DateTime.Now)   //araç eski bir tarihe kiralanamayacağı için 
                {
                    _rentalDal.Add(rental);
                    return new SuccessDataResult<Rental>(Messages.RentalAdded);
                }
                else return new ErrorResult(Messages.RentDateError);


            }

            else return new ErrorResult(Messages.RentError);
            

        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetbyCarId(int CarId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetByCustomerId(int CustomerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetById(int rentalId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<RentalDetailDto> GetRentControl(int carId)
        {
            return  new SuccessDataResult<RentalDetailDto>(_rentalDal.RentControl(carId));
        
        }

        public IDataResult<List<RentalDetailDto>> GetRentList()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentList());

        }

        public IResult Update(Rental rental)
        {
            throw new NotImplementedException();
        }
    }
}
