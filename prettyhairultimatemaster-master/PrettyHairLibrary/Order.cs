using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrettyHairLibrary
{
   public class Order
    {
        // Unique key for the product, and then the amount of this product in the order
        private List<OrderLine> ListOfOrderLines;
        public DateTime deliveryDate { get; private set; }
        public DateTime orderDate { get; private set; }
        public Customer customer { get; private set; }
        public bool Registered { get; set; }
        public int OrderId { get; private set; }

        public Order(int orderid, DateTime dd, DateTime od, List<OrderLine> ol, Customer cus)
        {
            ListOfOrderLines = ol;
            deliveryDate = dd;
            orderDate = od;
            OrderId = orderid;
            customer = cus;
        }

        public Order(int id, DateTime date, DateTime dd, List<ProductType> productTypes, List<int> quantity, Customer c)
        {
            OrderId = id;
            orderDate = date;
            deliveryDate = dd;
            customer = c;
            ListOfOrderLines = new List<OrderLine>();
            for (int i = 0; i < productTypes.Count; i++)
            {
                OrderLine ol = new OrderLine(productTypes[i], quantity[i]);
                ListOfOrderLines.Add(ol);
            }
        }

        public Order(int orderid, DateTime dd, DateTime od, Customer cus)
        {
            deliveryDate = dd;
            orderDate = od;
            OrderId = orderid;
            customer = cus;
        }

        /*public bool CheckQuantity()
        {
            bool cond = true;

            foreach(OrderLine ol in ListOfOrderLines)
            {
                //WE NEED TO ACCESS PRODUCTTYPEREPOSITORY
                if (ol.Quantity < p.Value) {
                    cond = false;
                }
            }
            return cond;
        }*/

        public List<OrderLine> GetOrderLines()
        {
            return ListOfOrderLines;
        }

        public Order()
        {

        }
        public override string ToString()
        {

            string orderString = "order [deliverydate="+ this.deliveryDate +", orderdate="+this.orderDate+"]";
            return orderString;
        }
    }
}
