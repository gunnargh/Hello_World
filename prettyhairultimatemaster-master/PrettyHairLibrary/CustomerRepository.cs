using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class CustomerRepository
    {
        private static CustomerRepository instance;

        private CustomerRepository() { }


        public static CustomerRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerRepository();
                }
                return instance;
            }
        }

        Dictionary<int, Customer> listOfCustomers = new Dictionary<int, Customer>();

        public void Clear()
        {
            listOfCustomers.Clear();
        }

        public int CountCustomers()
        {
            return listOfCustomers.Count;
        }

        public Customer Create(int id, string name, string address)
        {
            Customer customer = new Customer(id, name, address);
            listOfCustomers.Add(id, customer);
            return customer;
        }

        public Customer Load(int id)
        {
            if (listOfCustomers.ContainsKey(id))
                return listOfCustomers[id];
            else
                return null;
        }

        public void Remove(int id)
        {
            listOfCustomers.Remove(id);
        }

        public void ChangeAddress(string newAddress, int id)
        {
            listOfCustomers[id].Address = newAddress;
        }

        public Dictionary<int, Customer> GetListOfCustomers()
        {
            return listOfCustomers;
        }


        public int NewCustomerId()
        {
            return listOfCustomers.Count + 1;
        }
    }
}
