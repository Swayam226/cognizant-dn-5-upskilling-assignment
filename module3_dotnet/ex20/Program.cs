using System;
using System.Collections.Generic;
using System.Linq;

class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalAmount { get; set; }
}

class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>
        {
            new Order { OrderId = 1, CustomerName = "Alice", TotalAmount = 250.00 },
            new Order { OrderId = 2, CustomerName = "Bob", TotalAmount = 89.99 },
            new Order { OrderId = 3, CustomerName = "Charlie", TotalAmount = 450.50 },
            new Order { OrderId = 4, CustomerName = "Diana", TotalAmount = 120.00 },
            new Order { OrderId = 5, CustomerName = "Ethan", TotalAmount = 600.00 }
        };

        var filteredOrders = orders
            .Where(o => o.TotalAmount > 100)
            .Select(o => new { o.OrderId, o.CustomerName, o.TotalAmount });

        Console.WriteLine("Orders with TotalAmount > 100:");
        foreach (var order in filteredOrders)
            Console.WriteLine("  OrderId: " + order.OrderId + ", Customer: " + order.CustomerName + ", Total: " + order.TotalAmount);
    }
}
