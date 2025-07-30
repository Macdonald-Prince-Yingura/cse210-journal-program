using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Apple St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LPT123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MSE456", 25.00, 2));

        Address address2 = new Address("456 Mango Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Sarah Johnson", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "PHN789", 699.99, 1));
        order2.AddProduct(new Product("Charger", "CHR321", 19.99, 3));

        Console.WriteLine("----- Order 1 -----");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine("----- Order 2 -----");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost():F2}");
    }
}
