namespace OrderAPI.Models
{
    public class Order
    {
        public int Id { get; set; }
        public OrderDetails Details { get; set; }

        public Order(int id, OrderDetails details)
        {
            Id = id;
            Details = details;
        }

        // EF映射需要一个无参数的构造函数
        public Order()
        {
        }
    }
}
