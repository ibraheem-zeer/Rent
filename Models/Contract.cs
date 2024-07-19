using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class Contract
    {
        public Building Building { get; set; }
        public Users User { get; set; }
        public IPaymentMethods PaymentMethods { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public double Price { get; set; }

        public Contract(Building building, Users user, IPaymentMethods paymentMethod, string strDate, string endDate, double price)
        {
            this.Building = building;
            this.User = user;
            this.PaymentMethods = paymentMethod;
            this.StartDate = strDate;
            this.EndDate = endDate;
            this.Price = price;
        }

        public void Details()
        {
            Console.WriteLine($"User name : {User.Name} , and ID : {User.Id}");
            Building.Info();
            PaymentMethods.Payment(Price);
            Console.WriteLine($"the Contract will start from {StartDate} to {EndDate}");
        }

    }
}
