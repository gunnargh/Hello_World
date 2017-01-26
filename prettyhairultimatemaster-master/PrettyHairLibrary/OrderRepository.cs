using System;
using System.Collections.Generic;

namespace PrettyHairLibrary
{
    public class OrderRepository
    {
        private static OrderRepository instance;

        private OrderRepository() { }

        public static OrderRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderRepository();
                }
                return instance;
            }
        }

        public event TickHandler Tick;
        public EventArgs e = null;
        public delegate void TickHandler(OrderRepository m, EventArgs e);
        private List<Order> _orders = new List<Order>();

        public void Add(Order o)
        {
            _orders.Add(o);
            this.ReceivedOrderNotification();
            //if (!o.CheckQuantity()) NotifyWarehouseManagerAboutAmount(); 
        }

        public Order InsertOrder(Customer customer, DateTime date, DateTime deliveryDate, int orderId, List<int> quantity, List<ProductType> productTypes, bool registered, ProductTypeRepository repoPr)
        {
            Order order = new Order(orderId, date, deliveryDate, productTypes, quantity, customer);
            order.Registered = registered;
            _orders.Add(order);
            return order;
        }

        private void ReceivedOrderNotification()
        {
            // if diff from null
            Tick?.Invoke(this, e);
        }


        public List<Order> GetOrders()
        {
            return _orders;
        }
        private void NotifyWarehouseManagerAboutAmount()
        {
            // if diff from null
            Tick?.Invoke(this, e);
        }


        public void Remove(Order o) {
            _orders.Remove(o);
        }

        public void Remove(int orderid)
        {
            _orders.Remove(FindOrder(orderid));
        }

        public void Clear()
        {
            _orders.Clear();
        }
        public Order FindOrder(int orderid)
        {
            Order o = null;
            foreach (Order ord in _orders)
            {
                if (ord.OrderId == orderid) o = ord;
            }
            return o;
        }

        public Order GetOrder(int orderid)
        {
            return FindOrder(orderid);
        }

    }
}
