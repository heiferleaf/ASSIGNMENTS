using System;
using HW6.Core.Model;

namespace HW6.Core.Service
{
    class AddException : ApplicationException
    {
        public AddException(string message) : base(message) { }
    }

    class DeleteException : ApplicationException
    {
        public DeleteException(string message) : base(message) { }
    }

    class UpdateException : ApplicationException
    {
        public UpdateException(string message) : base(message) { }
    }

    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public List<Order> Orders { get { return orders; } set { orders = value; } }
        // 使用LINQ语句实现对订单的增删改查
        public OrderService() { }

        public Order SelectOrder(int orderId)
        {
            var query = from order in orders
                        .Where(orders => orders.OrderId == orderId)
                        select order;
            if(query.Count() > 0)
            {
                return query.First();
            }
            else
            {
                return null;
            }
        }

        public void AddOrder(int orderId, OrderDetails orderDetails)
        {
            if(SelectOrder(orderId) != null)
            {
                throw new AddException("Order already exists.");
            }
            Order order = new Order(orderId, orderDetails);
            orders.Add(order);
            return;
        }

        public void UpdateOrder(int orderId, OrderDetails orderDetails) { 
            if(SelectOrder(orderId) == null)
            {
                throw new UpdateException("Order does not exist.");
            }
            Order order = SelectOrder(orderId);
            order.OrderDetails = orderDetails;
            return;
        }

        public void DeleteOrder(int orderId)
        { 
            if(SelectOrder(orderId) == null)
            {
                throw new DeleteException("Order does not exist.");
            }
            Order order = SelectOrder(orderId);
            orders.Remove(order);
        }

        public void ShowOrders() {
            var query = from order in orders
                        .OrderBy(Order => Order.OrderDetails.OrderPrice)
                        select order;
            foreach(Order order in query)
            {
                Console.WriteLine(order);
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}