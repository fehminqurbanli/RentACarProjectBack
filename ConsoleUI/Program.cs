using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Enitites.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //Color color = new Color
            //{
            //    Name = "White"
            //};
            //ColorManager colorManager = new ColorManager(new ColorDal());
            //colorManager.Add(color);
            //Car car = new Car
            //{
            //    DailyPrice=500,
            //    ColorId=2,
            //    BrandId=1,
            //    Description="New car",
            //    ModelYear=2005
            //};
            Rental rental = new Rental()
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Now,
                ReturnDate=new DateTime(2020,05,10)
            };
            RentalManager rentalManager = new RentalManager(new RentalDal());
            rentalManager.Add(rental);
            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.CarId);
            }
            Console.ReadKey();
        }
    }
}
