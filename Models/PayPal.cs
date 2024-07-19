using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class PayPal : IPaymentMethods
    {
        public string MethodName { get; set; }
        public string Email { get; set; }

        public PayPal(string email)
        {
            this.Email = email;
        }
        public void Payment(double amount)
        {
            Console.WriteLine($"Amount : {amount} , Email : {Email}");
        }
    }
}
