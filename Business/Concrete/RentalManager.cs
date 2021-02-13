using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {

            if (rental.ReturnDate==null)
            {
                return new ErrorResult(Messages.Invalid);
            }
            else
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Added);
            }
        }

        public IResult CheckReturnDate(Rental rental)
        {
            if (rental.ReturnDate == null)
            {
                return new ErrorResult(Messages.Invalid);
            }
            else
            {
                return new SuccessResult(Messages.Success);
            }
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult UpDateReturnDate(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.Success);
        }
    }
}
