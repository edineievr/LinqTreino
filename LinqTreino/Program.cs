using LinqTreino;

var ordersToShow = Data.Orders.Select(order => new
{
    order.Id,
    CustomerName = Data.Customers.First(customer => customer.Id == order.CustomerId).Name,
    OrderDate = order.OrderDate,
}).ToList();

foreach (var order in ordersToShow)
{
       Console.WriteLine($"Order ID: {order.Id}, Customer: {order.CustomerName}, Date: {order.OrderDate}");
}



