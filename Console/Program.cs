using Business.Concrete;
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

            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("id:{0} | Marka:{1} | Renk:{2} | Açıklama: {3}  | Günlük Ücret: {4} ",car.Id,car.BrandId,car.ColorId,car.Description,car.DailyPrice);

            }

          //  CarManager carManager = new CarManager(new InMemoryCarDal());



            
            





        }
    }
}
