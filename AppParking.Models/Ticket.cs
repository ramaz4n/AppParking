using System;
using System.Collections.Generic;
using System.Text;

namespace AppParking.Models
{
    public class Ticket
    {
        public string Id { private set; get; }

        public DateTime Time { get; set; }

        public Ticket(DateTime time)
        {
            Id = Guid.NewGuid().ToString();
            Time = time;
        }
    }
}
