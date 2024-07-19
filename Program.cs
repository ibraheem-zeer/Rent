using RentApp.Models;

namespace RentApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building apartment = new Apartment("ffApartment", "Hebron", 20.5, 50);
            Building house = new House("ffHouse", "Ramallah", 20.5, 50);
            Building shop = new Shop("ffShop", "Nablus", 20.5, "Accessories");

            Users user = new Users(1, "Ibraheem");

            PayPal payPal = new PayPal("ibraheem@gmail.com");
            Visa visa = new Visa(202020202023040, "20/1/25", 787);
            MasterCard masterCard = new MasterCard(202020202023040, "20/1/25", 787);

            Contract con1 = new Contract(apartment, user, visa, "15/12/2024", "15/12/2027", 70000);
            Contract con2 = new Contract(house, user, masterCard, "15/12/2024", "15/12/2027", 100000);
            Contract con3 = new Contract(shop, user, payPal, "15/12/2024", "15/12/2027", 50000);

            user.AddContract(con1);
            user.AddContract(con2);
            user.AddContract(con3);
        }
    }
}
