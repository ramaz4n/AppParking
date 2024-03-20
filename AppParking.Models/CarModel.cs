using System;

namespace AppParking.Models
{
    public class CarModel
    {
        public string Number { get; set; }
        public string Model { get; set; }

        public string Id { private set; get; }

        public CarModel(string id, string number, string model)
        {
            Id = id;
            Number = number;
            Model = model;
        }

    }
}
