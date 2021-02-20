using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {

        IResult Add(Rental rental, int carId);

        IResult Update(Rental rental);

        IResult Delete(Rental rental);

        IDataResult<List<Rental>> GetAll();

        IDataResult<List<Rental>> GetById(int rentalId);

        IDataResult<List<Rental>> GetByCustomerId(int CustomerId);

        IDataResult<List<Rental>> GetbyCarId(int CarId);

        IDataResult<RentalDetailDto> GetRentControl(int carId);

        IDataResult<List<RentalDetailDto>> GetRentList();

        



    }
}
