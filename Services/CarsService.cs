using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist10.Models;
using gregslist10.db;

namespace gregslist10.Services
{
    public class CarsService
    {
        internal List<Car> Get()
        {
            return FakeDb.Cars;
        }

        internal Car Get(string id)
        {
            Car found = FakeDb.Cars.Find(c => c.Id == id);
            if (found == null)
            {
                throw new Exception("Bad Id");
            }
            return found;
        }

        internal Car Create(Car carData)
        {
            FakeDb.Cars.Add(carData);
            return carData;
        }

        internal Car Update(Car carData)
        {
            Car original = Get(carData.Id);
            original.Name = carData.Name ?? original.Name;
            return original;
        }

        internal Car Delete(string id)
        {
            Car found = Get(id);
            FakeDb.Cars.Remove(found);
            return found;
        }
    }
}