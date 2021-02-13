using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color color)
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Color>> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
