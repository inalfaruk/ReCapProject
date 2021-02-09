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
            {
                _brandDal.Add(brand);

                Console.WriteLine("Kayıt Tamamlanmıştır. \n Marka: " + brand.Name);
            }
        }

        public void Delete(Brand brand)
        {
            _brandDal.Delete(brand);
        }

        public List<Brand> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetById()
        {
            throw new NotImplementedException();
        }

        public void Update(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}
