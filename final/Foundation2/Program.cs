using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creating customers
        Address address1 = new Address("45 Goat st", "Chicago", "IL", "USA");
        Customer customer1 = new Customer("Dee Christianson", address1);

        Address address2 = new Address("456 Elm St", "Manchester", "Alberta", "Canada");
        Customer customer2 = new Customer("Jannet Smith", address2);

        // Creating products
        Product product1 = new Product("Laptop", 10001, 1000, 5);
        Product product2 = new Product("Smartphone", 10002, 700, 2);
        Product product3 = new Product("Keyboard", 10003, 50, 2);
        Product product4 = new Product("Mouse", 10004, 25, 2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        // Displaying order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    } 
}