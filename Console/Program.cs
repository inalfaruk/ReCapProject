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
            // AddRental();

            RentList();

           
            //AddUser();
            //AddCustomer();
            //AddCar();
            //AddColor();
            //AddBrand();
            //DailyPrice();
            //GetCarsByBrandId();


            //DeleteCar();





            //  Inmemory();

 static void RentList()
            {
                RentalManager rentalManager = new RentalManager(new EfRentalDal());
                var result = rentalManager.GetRentList();

                foreach (var rent in result.Data)
                {
                    Console.WriteLine("Araç = " + rent.CarName + " - Marka= " + rent.BrandName + " -  Renk= " + rent.ColorName + " - Günlük Ücret= " + rent.DailyPrice + " - Ad Soyad= " + rent.FirstName + " " + rent.LastName);

                }
            }

        }

        private static void AddRental()
        {
            Rental rental = new Rental();

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rental.CarId = 7;
            rental.CustomerId = 2;
            rental.RentDate = Convert.ToDateTime("23.02.2021");
            //rental.ReturnDate = Convert.ToDateTime("24.01.2020"); 

            var result = rentalManager.Add(rental,rental.CarId);
            Console.WriteLine(result.Message);


           
        }

        private static void AddCustomer()
        {
            Customer customer = new Customer();
            customer.UserId = 1002;
            customer.CompanyName = "Burger King";
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(customer);

            if (result.Success)
            {
                Console.WriteLine(result.Message);
            }
        }

        //private static void AddUser()
        //{
        //    User2 user = new User2();
        //    user.FirstName = "Kerim";
        //    user.LastName = "Taştan";
        //    user.Email = "tastankerim@mail.com";
        //    user.Password = "5432";


        //    UserManager2 userManager = new UserManager2(new EfUserDal2());
        //    var result = userManager.Add(user);
        //    userManager.Add(user);
           

        //    if (result.Success)
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}

        private static void DeleteCar()
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
            brand.BrandName = "Mercedes";
            brandManager.Add(brand);
        }

        private static void AddBrand()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Brand brand = new Brand();
            brand.BrandName = "Bmw";
            brandManager.Add(brand);
        }

        private static void AddColor()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Color color = new Color();
            color.ColorName = "Mavi";
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
