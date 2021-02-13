using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Brand brand)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll()
        {
            //iş kodları
            return _brandDal.GetAll();
        }

        public Brand GetById(int BrandId)
        {
            return _brandDal.Get(b => b.BrandId == BrandId);
        }

        public IResult Update(Brand brand)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Brand>> IBrandService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<Brand> IBrandService.GetById(int BrandId)
        {
            throw new NotImplementedException();
        }
    }
}
