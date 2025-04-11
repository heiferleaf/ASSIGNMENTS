using OrderAPI.Models;
using OrderAPI.Repositorys;

namespace OrderAPI.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        // 通过构造函数实现依赖注入
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task AddOrderAsync(Order order)
        {
            if(order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            await _orderRepository.AddOrderAsync(order);
        }
        public async Task DeleteOrderAsync(int id)
        {
            await _orderRepository.DeleteOrderAsync(id);
        }
        public async Task<Order> GetOrderByIdAsync(int id)
        {
            var order =  await _orderRepository.GetOrderByIdAsync(id);
            if(order == null)
            {
                throw new Exception($"Order with ID {id} not found.");
            }
            return order;
        }
        public async Task<List<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.GetAllOrdersAsync();
        }
        public async Task UpdateOrderAsync(Order order)
        {
            var uporder = await _orderRepository.GetOrderByIdAsync(order.Id);
            if(uporder == null)
            {
                throw new Exception($"Order with ID {order.Id} not found.");
            }
            await _orderRepository.UpdateOrderAsync(order);
        }
    }
}
