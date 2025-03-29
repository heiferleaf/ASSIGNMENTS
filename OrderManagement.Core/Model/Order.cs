using System;

namespace HW6.Core.Model
{
    public class Order
    {
        private int orderId;
        private OrderDetails orderDetails;

        public int OrderId { get { return orderId; } set { orderId = value; } }
        public OrderDetails OrderDetails { get { return orderDetails; } set { orderDetails = value; } }

        public Order(int orderId, OrderDetails orderDetails)
        {
            this.orderId = orderId;
            this.orderDetails = orderDetails;
        }

        public override string ToString()
        {
            string result = String.Format("Order ID: {0}, Order Details: {1}", orderId, orderDetails);
            return result;
        }

        public override bool Equals(object? obj)
        {
            Order order = obj as Order;
            if (order == null) return false;
            return orderId == order.orderId && orderDetails.Equals(order.orderDetails);
        }
    }
}