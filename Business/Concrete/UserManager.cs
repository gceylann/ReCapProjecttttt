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
    public class UserManager : IUserService

    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult Add(User user)
        {
            if (user.FirstName.Length>2)
            {
                return new ErrorResult(Messages.UserNameInvalid);
            }
            _userDal.Add(user);
            return new SuccessResult(Messages.Added);
        }

        public IResult Delete(User user)
        {
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetById(int UserId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
