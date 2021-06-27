using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=78000,ModelYear="2013",Description="Renault Symbol; Tertemiz,Kazasız,Boyasız Araç"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=120000,ModelYear="2015",Description="Renault Megane; Lokal Boyalıdır"},
                new Car{Id=3,BrandId=2,ColorId=3,DailyPrice=180000,ModelYear="2017",Description="VW Scirocco; 3500TL Hasar Kaydı Vardır"},
                new Car{Id=4,BrandId=3,ColorId=3,DailyPrice=300000,ModelYear="2019",Description="VW Passat; Acil Satılık"},
                new Car{Id=5,BrandId=4,ColorId=2,DailyPrice=1250000,ModelYear="2021",Description="Dodge Charger; Türkiyede Sadece Sınırlı Sayıda Bulunmaktadır."}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Description = car.Description;
        }
    }
}
