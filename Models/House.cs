using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class House : Building
    {
        public override string Name { get; set; }
        public override string Address { get; set; }
        public override double Volume { get; set; }

        public int Floor { get; set; }

        public House(string name, string address, double volume, int floor) : base(name, address, volume)
        {
            this.Floor = floor;
        }

        public override void Info()
        {
            Console.WriteLine($"House : {Name} , Address : {Address} , Size : {Volume} , Floor : {Floor}");
        }
    }
}
