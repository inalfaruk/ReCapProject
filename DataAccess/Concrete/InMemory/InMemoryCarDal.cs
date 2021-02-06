using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal :ICarDal
    {


        List<Car> _cars;


        public InMemoryCarDal()
        {


            _cars = new List<Car>
            {

               new Car { Id=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Temizlenecek",ModelYear="2019"},
               new Car { Id=2,BrandId=1,ColorId=2,DailyPrice=220,Description="Müşteride",ModelYear="2020"},
               new Car { Id=3,BrandId=2,ColorId=1,DailyPrice=330,Description="Hazır",ModelYear="2018"},
               new Car { Id=4,BrandId=3,ColorId=3,DailyPrice=300,Description="Hazır",ModelYear="2020"},
               new Car { Id=5,BrandId=3,ColorId=2,DailyPrice=400,Description="Tamirde",ModelYear="2021"},
               new Car { Id=6,BrandId=4,ColorId=4,DailyPrice=280,Description="Arızalı",ModelYear="2016"}


             };


        }
        

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car cartoUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            cartoUpdate.BrandId = car.BrandId;
            cartoUpdate.ColorId = car.ColorId;
            cartoUpdate.DailyPrice = car.DailyPrice;
            cartoUpdate.Description = car.Description;
            cartoUpdate.ModelYear = car.ModelYear;
        }
    }
}
