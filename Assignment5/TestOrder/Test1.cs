using System;
using System.Data.Common;
using System.Data;
using HW5.Order;

namespace TestOrder
{
    [TestClass]
    public class OrderServiceTests
    {
        private OrderService orderService;

        [TestInitialize]
        public void Setup()
        {
            orderService = new OrderService();
        }

        [TestMethod]
        public void AddOrder_ShouldAddNewOrder_WhenOrderDoesNotExist()
        {
            // Arrange
            int orderId = 1;
            string name = "Test Product";
            string client = "Test Client";
            double price = 100.0;

            // Act
            orderService.AddOrder(orderId, name, client, price);

            // Assert
            Assert.AreEqual(1, orderService.GetLen());
        }

        [TestMethod]
        [ExpectedException(typeof(AddException))]
        public void AddOrder_ShouldThrowException_WhenOrderExists()
        {
            // Arrange
            int orderId = 1;
            string name = "Test Product";
            string client = "Test Client";
            double price = 100.0;
            orderService.AddOrder(orderId, name, client, price); // Add once to ensure it exists

            // Act
            orderService.AddOrder(orderId, name, client, price); // Try to add the same order again

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void RemoveOrder_ShouldRemoveOrder_WhenOrderExists()
        {
            // Arrange
            int orderId = 1;
            string name = "Test Product";
            string client = "Test Client";
            double price = 100.0;
            orderService.AddOrder(orderId, name, client, price);

            // Act
            orderService.RemoveOrder(orderId);

            // Assert
            Assert.AreEqual(0, orderService.GetLen());
        }

        [TestMethod]
        [ExpectedException(typeof(RemoveException))]
        public void RemoveOrder_ShouldThrowException_WhenOrderDoesNotExist()
        {
            // Arrange
            int orderId = 1;

            // Act
            orderService.RemoveOrder(orderId);

            // Assert is handled by ExpectedException
        }

        [TestMethod]
        public void UpdateOrder_ShouldUpdateOrder_WhenOrderExists()
        {
            // Arrange
            int orderId = 1;
            string originalName = "Test Product";
            string newName = "Updated Product";
            string client = "Test Client";
            double price = 100.0;
            orderService.AddOrder(orderId, originalName, client, price);

            // Act
            orderService.UpdataOrder(orderId, newName, client, price);

            // Assert
            Assert.AreEqual(newName, orderService.SelectOrders(orderId));
        }

        [TestMethod]
        [ExpectedException(typeof(UpdataException))]
        public void UpdateOrder_ShouldThrowException_WhenOrderDoesNotExist()
        {
            // Arrange
            int orderId = 1;
            string name = "Test Product";
            string client = "Test Client";
            double price = 100.0;

            // Act
            orderService.UpdataOrder(orderId, name, client, price);

            // Assert is handled by ExpectedException
        }

    }
}
