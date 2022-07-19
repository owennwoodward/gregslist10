using System;


namespace gregslist10.Models
{
    public class Car
    {
        public Car(string name)
        {
            Id = Guid.NewGuid().ToString();
            Name = name;
        }

        public string Id { get; set; }
        public string Name { get; set; }
    }
}