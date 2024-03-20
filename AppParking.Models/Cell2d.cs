using System;
using System.Collections.Generic;
using System.Text;

namespace AppParking.Models
{
    public class Cell2d
    {
        public int Row { get; set; }
        public int Col { get; set; }

        public CarModel car { get; set; }

        public DriverModel driver { get; set; }

        public Ticket ticket { get; set; }

    }
}
