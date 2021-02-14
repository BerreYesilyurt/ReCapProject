using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1, BrandId=1,ColorId=1,ModelYear=2021, DailyPrice=305, Description="Honda Civic Hatchback"},
                new Car{Id=2, BrandId=2,ColorId=2, ModelYear=2021, DailyPrice=329, Description="Isuzu D-MAX"},
                new Car{Id=3, BrandId=1,ColorId=1, ModelYear=2013, DailyPrice=89, Description="LİNEA POP 1.3 M.JET"},
                new Car{Id=4, BrandId=2,ColorId=3, ModelYear=2005, DailyPrice=50, Description="Hyundai 1.5 CRDi Admire"},
                new Car{Id=5, BrandId=2, ColorId=2,ModelYear=2012, DailyPrice=123, Description="Citroen 1.4 e-HDi Confort"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {

            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
    }
