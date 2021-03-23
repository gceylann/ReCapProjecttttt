using Business.Abstract;
using Business.Constants;
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
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.Added);
        }

        public List<Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public IDataResult<Color> GetById(int ColorId)
        {
            return new SuccessDataResult<Color>(_colorDal.Get(co => co.ColorId == ColorId));
        }

        public IResult Update(Color color)
        {
            return new SuccessResult(Messages.Updated);
        }

        IDataResult<List<Color>> IColorService.GetAll()
        {
            return new SuccessDataResult<List<Color>>(_colorDal.GetAll(), Messages.Listed);
        }
    }
}
