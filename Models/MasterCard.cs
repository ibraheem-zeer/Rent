using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class MasterCard : IPaymentMethods
    {
        public string MethodName { get; set; }
        public BigInteger CardNo { get; set; }
        public string Date { get; set; }
        public int CVC { get; set; }

        public MasterCard(BigInteger cardNo, string date, int cvc)
        {
            this.MethodName = "Master Card";
            this.CardNo = cardNo;
            this.Date = date;
            this.CVC = cvc;
        }

        public void Payment(double amount)
        {
            Console.WriteLine($"Amount : {amount} , from {MethodName} and your card number is : {CardNo}");
        }
    }
}
