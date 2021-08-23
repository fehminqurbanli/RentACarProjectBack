using DataAccess.Abstract;
using Enitites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal //: ICarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car>()
        //    {
        //        new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=50,ModelYear=2020,Description="New car"},
        //        new Car{Id=2,BrandId=2,ColorId=2,DailyPrice=510,ModelYear=2010,Description="New car"},
        //        new Car{Id=3,BrandId=3,ColorId=1,DailyPrice=580,ModelYear=2021,Description="New car"},
        //    };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    var deletedCar = _cars.Find(c => c.Id == car.Id);
        //    _cars.Remove(deletedCar);
        //}

        //public List<Car> GetAll()
        //{
        //    return _cars.ToList();
        //}

        //public Car GetById(int id)
        //{
        //    return _cars.Where(c => c.Id == id).FirstOrDefault();
        //}

        //public void Update(Car car)
        //{
        //    var updatedCar = _cars.Find(c => c.Id == car.Id);
        //    updatedCar.BrandId = car.BrandId;
        //    updatedCar.ColorId = car.ColorId;
        //    updatedCar.DailyPrice = car.DailyPrice;
        //    updatedCar.Description = car.Description;
        //}
    }
}
