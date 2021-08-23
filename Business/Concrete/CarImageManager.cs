using Business.Abstract;
using Business.Constants;
using Core.Results;
using Core.Utilities;
using Core.Utilities.Business;
using DataAccess.Abstract;
using Enitites.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file,CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckCarMaxImageLimit(carImage.CarId));
            var carImageResult = FileHelperManager.Upload(file);
            if (!carImageResult.Success)
            {
                return new ErrorResult(carImageResult.Message);
            }
            carImage.ImagePath = carImageResult.Message;
            carImage.Date = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            _carImageDal.GetAll();
            return new SuccessDataResult<List<CarImage>>();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            _carImageDal.Get(c => c.Id == id);
            return new SuccessDataResult<CarImage>();

        }

        public IResult Update(IFormFile file,CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        private IResult CheckCarMaxImageLimit(int id)
        {
            var result = _carImageDal.GetAll(c => c.CarId == id).Count;
            if (result>5)
            {
                return new ErrorResult("Limit exceeded");
            }
            return new SuccessResult();
        }

    }
}
