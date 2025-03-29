using System;

namespace HW6.Core.Model
{
    public class OrderDetails
    {
        private string orderName;
        private string orderClient;
        private double orderPrice;

        public string OrderName { get { return orderName; } set { orderName = value; } }
        public string OrderClient { get { return orderClient; } set { orderClient = value; } }
        public double OrderPrice { get { return orderPrice; } set { orderPrice = value; } }

        public OrderDetails() {
            OrderName = "Unknown";
            OrderClient = "Unknown";
            OrderPrice = 0.0;
        }

        public OrderDetails(string orderName, string orderClient, double orderPrice)
        {
            OrderName = orderName;
            OrderClient = orderClient;
            OrderPrice = orderPrice;
        }

        public override string ToString()
        {
            string result = String.Format("Order Name: {0}, Order Client: {1}, Order Price: {2}", orderName, orderClient, orderPrice);
            return result;
        }

        public override bool Equals(object? obj)
        {
            OrderDetails orderDetails = obj as OrderDetails;
            if (orderDetails == null) return false;
            return orderName == orderDetails.orderName && orderClient == orderDetails.orderClient && orderPrice == orderDetails.orderPrice;
        }
    }
}