using System;
using System.Text;

namespace HW5.Order
{
    public class AddException: Exception
    {
        public AddException(string message):base(message) { }
    }
    public class RemoveException : Exception
    {
        public RemoveException(string message) : base(message) { }
    }

    public class UpdataException : Exception 
    {
        public UpdataException(string message) : base(message) { }
    }

    class OrderDetails
    {
        private string name;
        private string client;
        private double price;

        public OrderDetails(string name, string client, double price)
        {
            this.name = name;
            this.client = client;
            this.price = price;
        }

        public string Name { get { return name; } set { name = value; } }
        public string Client { get { return client; } set { client = value; } }
        public double Price { get { return price; } set { price = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Name).Append(Client).Append(Price.ToString());
            return sb.ToString();
        }
    }

    class Order
    {
        // 订单id作为主键，非空唯一
        private int id;
        private OrderDetails details;

        public Order(int id, OrderDetails details)
        {
            this.id = id;
            this.details = details;
        }
        public int Id { get { return id; } }
        public string Name { get {return details.Name; } set { details.Name = value; } }
        public string Client { get { return details.Client; } set {details.Client = value; } }
        public double Price { get { return details.Price; } set {details.Price = value; } }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("订单ID: "  + Id.ToString());
           
            return sb.ToString() + details.ToString();
        }
    }

    public class OrderService
    {
        private List<Order> orders = new List<Order>();

        public void AddOrder(int id, string name, string client, double price)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
                throw new AddException("增加的元素已经存在");
            orders.Add(new Order(id, new OrderDetails(name, client, price)));
        }

        public void RemoveOrder(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                throw new RemoveException("删除的元素原本不存在");
            }
            else
            {
                orders.Remove(order);
            }
        }

        public void UpdataOrder(int id, string name, string client, double price)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                throw new UpdataException("更新的元素不存在");
            }
            else
            {
                order.Name = name;
                order.Client = client;
                order.Price = price;
            }
        }

        public string SelectOrders(int id)
        {
            var order = orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                Console.WriteLine("order doesn't exist ");
                return null;
            }
            Console.WriteLine(order);
            return order.Name;
        }

        public void SelectOrders()
        {
            var order = orders.OrderByDescending(o => o.Price).ThenBy(o => o.Id);
            foreach (var o in order) Console.WriteLine(o);
        }

        public void SortOrder()
        {
            if (orders == null)
                return;
            orders.Sort((o1, o2) =>  o1.Id - o2.Id);
        }

        public int GetLen()
        {
            return orders.Count;
        }

        static void Main(string[] args)
        {
            
        }
    }
}