using System;
using AppParking.Models;

namespace AppParking
{
    class Program
    {
        static void Main(string[] args)
        {
            IParking parking1 = new FlatParking(3, 2);
            var car1 = new CarModel("1", "a231fa", "BMW");
            var driver1 = new DriverModel("1", "Soul", "2341");

            var ticket1 = parking1.Set(car1, driver1);
            var car11 = parking1.Get(ticket1);
        }
    }
}
