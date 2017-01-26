using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public OrderRepository OrderRepository { get; set; }

        public Customer()
        {
            OrderRepository = OrderRepository.Instance;
        }
        public Customer(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
            OrderRepository = OrderRepository.Instance;
        }

        public override string ToString()
        {
            return Id + " - " + Name + " - " + Address;
        }
    }
}
