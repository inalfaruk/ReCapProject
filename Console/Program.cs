using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddCar();
            //AddColor();
            //AddBrand();
            //DailyPrice();
            //GetCarsByBrandId();


           //CarDelete();



            //  Inmemory();







        }

        private static void CarDelete()
        {
            Car car = new Car();

            CarManager carManager = new CarManager(new EfCarDal());
            car.Id = 2;

            carManager.Delete(car);
        }

        private static void GetCarsByBrandId()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAllCarsByBranId(1);

            foreach (var car in result.Data)
            {
                Console.WriteLine(car.ModelYear, car.DailyPrice);

            }
        }

        private static void AddCar()
        {
            Brand brand = new Brand();
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brand.Id = 1; // identity açık olduğundan id girmiyorum.
            brand.Name = "Mercedes";
            brandManager.Add(brand);
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.Name = "Bmw";
            brandManager.Add(brand);
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            color.Name = "Mavi";
            colorManager.Add(color);
        }

        private static void DailyPrice()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetDailyPrice();

            foreach (var car in result.Data)
            {
                Console.WriteLine("Araba= " + car.CarName + " - Marka= " + car.BrandName + " - Renk= " + car.ColorName + " - Günlük Ücret= " + car.DailyPrice);
            }
        }


        static void Inmemory()
            {
                CarManager carManager = new CarManager(new InMemoryCarDal());

            var result = carManager.GetAll();

                foreach (var car in result.Data)
                {
                    Console.WriteLine("id:{0} | Marka:{1} | Renk:{2} | Açıklama: {3}  | Günlük Ücret: {4} ", car.Id, car.BrandId, car.ColorId, car.Description, car.DailyPrice);

                }
            }





            //  CarManager carManager = new CarManager(new InMemoryCarDal());




        
    }
}
