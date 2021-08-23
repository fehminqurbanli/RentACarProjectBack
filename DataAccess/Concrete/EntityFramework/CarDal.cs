using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Enitites.Concrete;
using Enitites.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarDal:EfCoreRepositoryBase<Car,EfCoreDbContext>,ICarDal
    {
        public List<CarDetailsDto> GetCarDetailsDto()
        {
            using (EfCoreDbContext dbContext=new EfCoreDbContext())
            {
                var result = from c in dbContext.Cars
                             join b in dbContext.Brands on c.BrandId equals b.Id
                             join a in dbContext.Colors on c.ColorId equals a.Id
                             select new CarDetailsDto
                             {
                                 CarId=c.Id,
                                 BrandName=b.Name,
                                 ColorName=a.Name,
                                 DailyPrice=c.DailyPrice
                             };
                return result.ToList();

            }
        }
    }
}
