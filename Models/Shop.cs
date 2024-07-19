using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class Shop : Building
    {
        public override string Name { get; set; }
        public override string Address { get; set; }
        public override double Volume { get; set; }

        public string BusinessType { get; set; }
        public Shop(string name, string address, double volume, string BusinessType) : base(name, address, volume)
        {
            this.BusinessType = BusinessType;
        }

        public override void Info()
        {
            Console.WriteLine($"Shop : {Name} , Address : {Address} , Size : {Volume} , Business Type : {BusinessType}");
        }
    }
}
