using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using HW7.Core.Service;
using System.IO;
using System.Linq;
using System;
using HW7.Core.Context;

class Program
{
    static IServiceProvider BuildServiceProvider()
    {
        var services = new ServiceCollection();

        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();

        services.AddDbContext<MyDbContext>(options =>
            options.UseMySql(
                configuration.GetConnectionString("DefaultConnection"),
                ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection"))
            ));

        services.AddScoped<OrderService>();

        return services.BuildServiceProvider();
    }

    static void Main(string[] args)
    {
        using (var scope = BuildServiceProvider().CreateScope())
        {
            var orderService = scope.ServiceProvider.GetRequiredService<OrderService>();
            var dbContext = scope.ServiceProvider.GetRequiredService<MyDbContext>();

            dbContext.Database.Migrate();

            try
            {
                var od1 = new HW7.Core.Model.OrderDetails("Order1", "Client1", 100.0);
                orderService.AddOrder(orderService.SelectOrder(1) == null ? 1 : orderService._context.Orders.Count() + 1, od1);
                orderService.ShowOrders();

                var selectedOrder = orderService.SelectOrder(orderService._context.Orders.Count());
                Console.WriteLine($"Selected Order: {selectedOrder}");

                orderService.ShowOrders();

                orderService.UpdateOrder(orderService._context.Orders.Count(), new HW7.Core.Model.OrderDetails("Order2", "Client2", 200.0));
                orderService.ShowOrders();

                orderService.DeleteOrder(orderService._context.Orders.Count());
                orderService.ShowOrders();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }
    }
}