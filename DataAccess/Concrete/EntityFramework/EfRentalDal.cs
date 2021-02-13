using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, MyDatabaseContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (MyDatabaseContext context=new MyDatabaseContext())
            {
                var result = from r in context.Rentals
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join c in context.Cars
                             on r.CarId equals c.Id
                             select new RentalDetailDto
                             {
                                 CustomerId=cu.Id,
                                 CarId=c.Id,
                                 Id=r.Id,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                             };
                return result.ToList();
            }
        }
    }
}
