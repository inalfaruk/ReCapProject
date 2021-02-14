using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using System.Text;
using Core.Utilities.Results;
using Bussiness.Constants;

namespace Business.Concrete
{
   public class BrandManager :IBrandService
    {
        IBrandDal _brandDal;


        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {

            if (brand.Name.Length <= 2)
            {
                return new ErrorResult("Marka ismi minimum iki karakterter olmalıdır.");
               // Console.WriteLine();
            }
            else
            {
                _brandDal.Add(brand);
                return new SuccessResult(Messages.BrandAdded);
                
            }
        }

        public IResult Delete(Brand brand)
        {
          
            _brandDal.Delete(brand);
            return new SuccessResult( Messages.BrandDeleted);
        }

        public IResult Update (Brand brand)
        {

            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public  IDataResult<List<Brand>> GetAll()
        {

            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());

        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new SuccessDataResult<Brand>(_brandDal.Get(p => p.Id == brandId));
        }

       
    }
}
