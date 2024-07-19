using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentApp.Models
{
    internal class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Contract> Contracts { get; set; }

        public Users(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Contracts = new List<Contract>();
        }

        public Users()
        {

        }

        public void AddContract(Contract contract)
        {
            this.Contracts.Add(contract);

        }

        public void GetAllContracts()
        {
            Console.WriteLine($"User name: {Name}");
            foreach (Contract contract in Contracts)
            {
                contract.Details();
            }
        }

    }
}
