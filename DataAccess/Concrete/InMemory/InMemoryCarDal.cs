using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car> 
//            {
//            new Car{Id=1,BrandId=2,ColorId=1,DailyPrice=200,ModelYear="2010",Description="Manuel"},
//            new Car{Id=2,BrandId=1,ColorId=3,DailyPrice=300,ModelYear="2011",Description="Manuel"},
//            new Car{Id=3,BrandId=3,ColorId=2,DailyPrice=400,ModelYear="2012",Description="Manuel"},
//            new Car{Id=4,BrandId=2,ColorId=3,DailyPrice=500,ModelYear="2013",Description="Manuel"},
//            new Car{Id=5,BrandId=3,ColorId=2,DailyPrice=600,ModelYear="2014",Description="Manuel"}
//            };
//        }
       
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
//        }

//        public Car Get(Expression<Func<Car, bool>> filter)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public List<Car> GetAllByBrandId(int brandId)
//        {
//            return _cars.Where(c => c.BrandId == brandId).ToList();
//        }

//        public List<CarDetailDto> GetCarDetails()
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetCarDetails(Func<object, bool> p)
//        {
//            throw new NotImplementedException();
//        }

//        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
//            carToUpdate.Id = car.Id;
//            carToUpdate.BrandId = car.BrandId;
//            carToUpdate.ColorId = car.ColorId;
//            carToUpdate.DailyPrice = car.DailyPrice;
//            carToUpdate.ModelYear = car.ModelYear;
//            carToUpdate.Description = car.Description;
//        }
//    }
//}
