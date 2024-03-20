using System;
using System.Collections.Generic;
using System.Text;
using AppParking.Models;

namespace AppParking
{
    interface IParking
    {
        Ticket Set(CarModel car, DriverModel driver);
        CarModel Get(Ticket ticket);
    }
}
