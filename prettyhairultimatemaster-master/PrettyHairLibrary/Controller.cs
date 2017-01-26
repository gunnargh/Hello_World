using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
    public class Controller
    {
        ProductTypeRepository productTypeRepository = ProductTypeRepository.Instance;
        CustomerRepository customerRepository = CustomerRepository.Instance;
        OrderRepository orderRepository = OrderRepository.Instance;

        private void RegisterOrderAsPacked(int Id)
        {

            Order ord = orderRepository.GetOrder(Id);
            ord.Registered = true;
            DBFacade.ChangeOrder(ord);


        }
        public void InitializeRepositories()
        {
            try
            {
                InitializeProductTypeRepository();
                InitializeCustomerRepository();
            }
            catch (SqlException e)
            {
                throw e;
            }
        }
        private void InitializeProductTypeRepository()
        {
            DBFacade.GetProductTypes(productTypeRepository);
        }

        private void InitializeCustomerRepository()
        {
            DBFacade.GetCustomers(customerRepository);
        }

       

        public void InsertProduct(string description, float price, int amount)
        {
            DBFacade.InsertProduct(description, price, amount);
        }

        public void InsertCustomer(string name, string address)
        {

            DBFacade.InsertCustomer(name, address);
        }

        /*public void InsertOrder(int customerId, DateTime data, DateTime deliveryDate)
        {


            Customer cust = customerRepository.Load(customerId);

            //if (cust == null)
            //{
            //    UI.Clear();
            //    UI.WriteL("Customer not found in the DBFacade, please create one.");
            //    InsertCustomer();
            //    customerId = customerRepository.NewCustomerId();
            //}



            //int orderId = orderRepository.NewOrderNumber();
            //bool isChoosing = true;
            //List<OrderLine> listOfOrderLines = new List<OrderLine>();
            //do
            //{
            //    UI.Clear();
            //    ShowListOfProducts();
            //    UI.WriteL("Choose a product (any char to exit):");
            //    int productId;

            //    isChoosing = Int32.TryParse(Console.ReadLine(), out productId);

            //    if (isChoosing == true)
            //    {
            //        UI.WriteL("Choose a quantity:");
            //        int productQuantity = Convert.ToInt32(Console.ReadLine());
            //        listOfOrderLines.Add(new OrderLine(productTypeRepository.Load(productId), productQuantity));
            //    }

            //} while (isChoosing == true);

            DBFacade.InsertOrder(customerId, orderId, date, deliveryDate, listOfOrderLines);

        }*/

        public Dictionary<int, ProductType> GetProductList()
        {
            return productTypeRepository.load();
        }

        public Dictionary<int, Customer> GetcustomerList() //Get the list of customers
        {
            return customerRepository.GetListOfCustomers();
        }

        public List<Order> GetOrders() //Get the list of customers
        {
            return orderRepository.GetOrders();
        }
        
        public ProductType ShowProductById(int id)
        {


            ProductType product = productTypeRepository.GetProduct(id);

            return product;

        }

        public Customer ShowCustomerById(int id)
        {

            Customer cust = customerRepository.Load(id);
            return cust;
        }

        public void ChangeProductPrice(int id, float newPrice)
        {

            DBFacade.ChangeProductPrice(id, newPrice);

        }

        public void ChangeProductAmount(int id, int newAmount)
        {
            DBFacade.ChangeProductAmount(id, newAmount);
        }

        public void ChangeProductDescription(int id, string newDescription)
        {

            DBFacade.ChangeProductDescription(id, newDescription);
        }

        public void ChangeCustomerAddress(int id, string newAddress)
        {

            DBFacade.ChangeCustomerAddress(id, newAddress);
        }
        
    }
}
