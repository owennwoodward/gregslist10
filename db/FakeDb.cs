using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using gregslist10.Models;


namespace gregslist10.db
{
    public static class FakeDb
    {
        public static List<Car> Cars { get; set; } = new List<Car>(){
            new Car("Ferrari"),
            new Car("Honda"),
            new Car("Ford")
        };
    }
}