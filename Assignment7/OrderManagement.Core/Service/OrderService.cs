using System;
using System.Linq;
using HW7.Core.Model;
using HW7.Core.Context;

namespace HW7.Core.Service
{
    public class AddException : ApplicationException
    {
        public AddException(string message) : base(message) { }
    }

    public class DeleteException : ApplicationException
    {
        public DeleteException(string message) : base(message) { }
    }

    public class UpdateException : ApplicationException
    {
        public UpdateException(string message) : base(message) { }
    }

    public class OrderService
    {
        public readonly MyDbContext _context;

        // 通过构造函数注入 DbContext
        public OrderService(MyDbContext context)
        {
            _context = context;
        }

        public Order SelectOrder(int orderId)
        {
            var order = _context.Orders
                .FirstOrDefault(o => o.OrderId == orderId);
            return order;
        }

        public void AddOrder(int orderId, OrderDetails orderDetails)
        {
            // 修正逻辑：如果订单已存在，不应添加
            if (SelectOrder(orderId) != null)
            {
                throw new AddException("Order already exists.");
            }

            var order = new Order(orderId, orderDetails);
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(int orderId, OrderDetails orderDetails)
        {
            var order = SelectOrder(orderId);
            if (order == null)
            {
                throw new UpdateException("Order does not exist.");
            }

            order.OrderDetails = orderDetails;
            _context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = SelectOrder(orderId);
            if (order == null)
            {
                throw new DeleteException("Order does not exist.");
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public void ShowOrders()
        {
            var query = _context.Orders
                .OrderBy(o => o.OrderDetails.OrderPrice);

            foreach (var order in query)
            {
                Console.WriteLine(order);
            }
        }
    }
}