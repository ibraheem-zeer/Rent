using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal abstract class Building
    {
        public abstract string Name { get; set; }
        public abstract string Address { get; set; }
        public abstract double Volume { get; set; }

        public Building(string name, string address, double volume)
        {
            this.Name = name;
            this.Address = address;
            this.Volume = volume;
        }

        public abstract void Info();
    }
}
