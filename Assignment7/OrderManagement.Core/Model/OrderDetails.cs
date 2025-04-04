using System;

namespace HW7.Core.Model
{
    public class OrderDetails
    {
        public string OrderName { get; set; }
        public string ClientName { get; set; }
        public double OrderPrice { get; set; }

        public OrderDetails() { }

        public OrderDetails(string orderName, string clientName, double orderPrice)
        {
            OrderName = orderName;
            ClientName = clientName;
            OrderPrice = orderPrice;
        }

        public override string ToString()
        {
            return $"OrderName: {OrderName}, ClientName: {ClientName}, Price: {OrderPrice}";
        }
    }
}