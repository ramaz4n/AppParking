using AppParking.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppParking
{
    public class FlatParking : IParking
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        private List<Cell2d> Cells = new List<Cell2d>();
        public FlatParking(int rows, int cols): base()
        {
            if(rows > 0 && cols > 0)
            {
                Rows = rows;
                Cols = cols;
                for(var i=0; i < rows; i++)
                {
                    for(var j = 0; j < cols; j++)
                    {
                        
                    }
                }
            }

        }
        public CarModel Get(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public Ticket Set(CarModel car, DriverModel driver)
        {
            throw new NotImplementedException();
        }
    }
}
