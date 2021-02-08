using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using DataAccess.Abstract;
using System.Text;

namespace Business.Concrete
{
   public class BrandManager :IBrandService
    {
        IBrandDal _brandDal;


        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }


        public void Add(Brand brand)
        {

            if (brand.Name.Length <= 2)
            {
                Console.WriteLine("Marka ismi minimum iki karakterter olmalıdır.");
            }
            else
                _brandDal.Add(brand);

        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
