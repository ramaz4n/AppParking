using AppParking.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppParking
{
    public class CubeParking : IParking
    {
        int Rows { get; set; }
        int Cols { get; set; }
        int Floor { get; set;}

        List<Cell3D> Cells = new List<Cell3D>();
        public CubeParking(int rows, int cols, int floor) : base()
        {

            if (rows > 0 && cols > 0)
            {
                Rows = rows;
                Cols = cols;
                Floor = floor;

                for (var i = 0; i < rows; i++)
                {
                    for (var j = 0; j < cols; j++)
                    {
                        for(var k=0; k< floor;k++)
                        Cells.Add(new Cell3D
                        {
                            Row = i,
                            Col = j,
                            Floor = floor,
                            car = null,
                            driver = null,
                            ticket = null
                        });
                    }

                }

            }
        }

        public CarModel Get(Ticket ticket)
        {
            for (var i = 0; i < Cells.Count; i++)
            {
                if (Cells[i].ticket == ticket)
                {
                    var t = Cells[i].car;
                    Cells[i].car = null;
                    Cells[i].driver = null;
                    Cells[i].ticket = null;
                    return t;
                }
            }
            return null;
        }

        public Ticket Set(CarModel car, DriverModel driver)
        {
            for (var i = 0; i < Cells.Count; i++)
            {
                if (Cells[i].ticket == null)
                {
                    Cells[i].car = car;
                    Cells[i].driver = driver;
                    Cells[i].ticket = new Ticket();
                    return Cells[i].ticket;
                }
            }
            return null;
        }
    }
}
