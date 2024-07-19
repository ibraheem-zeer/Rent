using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class Apartment : Building
    {
        public override string Name { get; set; }
        public override string Address { get; set; }
        public override double Volume { get; set; }

        public int ParkenigSize { get; set; }

        public Apartment(string name, string address, double volume, int ParkenigSize) : base(name, address, volume)
        {
            this.ParkenigSize = ParkenigSize;
        }

        public override void Info()
        {
            Console.WriteLine($"Apartment : {Name} , Address : {Address} , Size : {Volume} , Parkenig Size : {ParkenigSize}");
        }
    }
}
