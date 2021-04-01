//using Business.Concrete;
//using DataAccess.Concrete.EntityFramework;
//using System;

//namespace ConsoleUI
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Test1();

//            RentalManager rentalManager = new RentalManager(new EfRentalDal());

//            var result = rentalManager.GetRentalDetails();

//            if (result.Success == true)
//            {
//                foreach (var rental in result.Data)
//                {
//                    Console.WriteLine(rental.CarBrandName + " " +rental.RentDate + " " + rental.ReturnDate);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }

//        }

//        private static void Test1()
//        {
//            CarManager carManager = new CarManager(new EfCarDal());

//            var result = carManager.GetCarDetails();

//            if (result.Success == true)
//            {
//                foreach (var car in result.Data)
//                {
//                    Console.WriteLine(car.CarId + "/" + car.BrandName);
//                }
//            }
//            else
//            {
//                Console.WriteLine(result.Message);
//            }
//        }
//    }
//}
