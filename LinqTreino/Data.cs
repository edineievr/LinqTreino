using System;
using System.Collections.Generic;
using System.Text;

namespace LinqTreino
{
    public static class Data
    {
        public static List<Customer> Customers = new List<Customer>
        {
            new() { Id = 1, Name = "Alice", City = "New York", Email = "alice@example.com" },
            new() { Id = 2, Name = "Bob", City = "Los Angeles", Email = "bob@example.com" },
            new() { Id = 3, Name = "Charlie", City = "Chicago", Email = "charlie@example.com" },
            new() { Id = 4, Name = "Diana", City = "New York", Email = "diana@example.com" },
            new() { Id = 5, Name = "Eve", City = "Miami", Email = "eve@example.com" }
        };

        public static List<Product> Products = new List<Product>
        {
            new() { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200 },
            new() { Id = 2, Name = "Headphones", Category = "Electronics", Price = 200 },
            new() { Id = 3, Name = "Keyboard", Category = "Electronics", Price = 100 },
            new() { Id = 4, Name = "Coffee Mug", Category = "Home", Price = 15 },
            new() { Id = 5, Name = "Notebook", Category = "Office", Price = 8 },
            new() { Id = 6, Name = "Pen", Category = "Office", Price = 3 }
        };

        public static List<Order> Orders = new List<Order>
        {
            new()
            {
                Id = 1,
                CustomerId = 1,
                OrderDate = DateTime.Now.AddDays(-10),
                Status = OrderStatus.Completed,
                Items = new List<OrderItem>
                {
                    new() { ProductId = 1, Quantity = 1 },
                    new() { ProductId = 2, Quantity = 2 }
                }
            },
            new()
            {
                Id = 2,
                CustomerId = 2,
                OrderDate = DateTime.Now.AddDays(-5),
                Status = OrderStatus.Pending,
                Items = new List<OrderItem>
                {
                    new() { ProductId = 3, Quantity = 1 },
                    new() { ProductId = 4, Quantity = 4 }
                }
            },
            new()
            {
                Id = 3,
                CustomerId = 1,
                OrderDate = DateTime.Now.AddDays(-3),
                Status = OrderStatus.Completed,
                Items = new List<OrderItem>
                {
                    new() { ProductId = 5, Quantity = 10 },
                    new() { ProductId = 6, Quantity = 20 }
                }
            },
            new()
            {
                Id = 4,
                CustomerId = 3,
                OrderDate = DateTime.Now.AddDays(-1),
                Status = OrderStatus.Canceled,
                Items = new List<OrderItem>
                {
                    new() { ProductId = 1, Quantity = 1 },
                    new() { ProductId = 4, Quantity = 2 }
                }
            },
            new()
            {
                Id = 5,
                CustomerId = 4,
                OrderDate = DateTime.Now,
                Status = OrderStatus.Completed,
                Items = new List<OrderItem>
                {
                    new() { ProductId = 2, Quantity = 1 },
                    new() { ProductId = 3, Quantity = 3 }
                }
            }
        };
    }
}
