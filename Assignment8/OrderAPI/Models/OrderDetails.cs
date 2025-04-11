using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace OrderAPI.Models
{
    // 声明 OrderDetails 类是列而不是表
    [Owned]
    public class OrderDetails
    {
        [Required]
        [StringLength(50)]
        public String OrderName { get; set; }
        [Required]
        [StringLength(50)]
        public String OrderClient { get; set; }
        public Double OrderPrice { get; set; }

        public OrderDetails(string orderName, string orderClient, double orderPrice)
        {
            OrderName = orderName;
            OrderClient = orderClient;
            OrderPrice = orderPrice;
        }
    }
}
