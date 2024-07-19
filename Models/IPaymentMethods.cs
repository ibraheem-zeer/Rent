using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal interface IPaymentMethods
    {
        public string MethodName { get; set; }

        public void Payment(double amount);
    }
}
