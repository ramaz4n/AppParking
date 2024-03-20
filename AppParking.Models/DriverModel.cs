using System;
using System.Collections.Generic;
using System.Text;

namespace AppParking.Models
{
    public class DriverModel
    {
        public string FullName { get; set; }
        public string License { get; set; }
        public string Id { private set; get; }

        public DriverModel()
        {
            Id = Guid.NewGuid().ToString();
        }
        public DriverModel(string id, string fullname, string license)
        {
            Id = id ?? Guid.NewGuid().ToString("N");
            FullName = fullname;
            License = license;
        }
    }
}
