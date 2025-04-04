namespace HW7.Core.Model
{
    public class Order
    {
        public int OrderId { get; set; }
        public OrderDetails OrderDetails { get; set; }

        public Order() { }

        public Order(int orderId, OrderDetails orderDetails)
        {
            OrderId = orderId;
            OrderDetails = orderDetails;
        }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, Details: {OrderDetails}";
        }
    }
}