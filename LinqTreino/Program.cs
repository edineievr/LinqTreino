using LinqTreino;
using System.Data;
using System.Runtime.CompilerServices;

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

var completedOrders = Data.Orders.Where(order => order.Status == OrderStatus.Completed).ToList();


//initial solution
var ordersSummary1 = Data.Orders.Select(order => new
{
    order.Id,
    CustomerName = Data.Customers.FirstOrDefault(customer => customer.Id == order.CustomerId)?.Name,
    TotalItemsQuantity = order.Items.Sum(item => item.Quantity)
});


//refined solution
var ordersSummary2 = Data.Orders.Join(Data.Customers, order => order.CustomerId, customer => customer.Id, (order, customer) => new
{
    order.Id,
    customer.Name,
    TotalItems = order.Items.Sum(item => item.Quantity)
});

foreach (var order in ordersSummary1)
{
    Console.WriteLine($"Order ID: {order.Id}, Customer: {order.CustomerName}, Total Items Quantity: {order.TotalItemsQuantity}");
}

var bigOrdedrs = Data.Orders.Any(order => order.Items.Count > 10);

Console.WriteLine(bigOrdedrs);

//Pedidos onde a quantidade de itens é maior que 2

var countItemsOrders = Data.Orders.Where(order => order.Items.Any(item => item.Quantity > 2)).Select(order => new
{
    order.Id
});

var productGroups = Data.Orders.SelectMany(order => order.Items).GroupBy(item => item.ProductId).Select(item => new
{
    productId = item.Key,
    Total = item.Sum(product => product.Quantity)
});

foreach (var item in productGroups)
{
    Console.WriteLine(item);
}

//Clientes que mais compraram itens no total

var topCustomers = Data.Customers.Join(Data.Orders, customer => customer.Id, order => order.CustomerId, (customer, order) => new
{
    
}).GroupBy(customer => new {customer.Id}).Select(group => new
{
    group.Key.Id,
    Total = group
    
}).OrderByDescending(customer => customer.Total).Take(3);

foreach (var customer in topCustomers)
{
    Console.WriteLine(customer);
}









