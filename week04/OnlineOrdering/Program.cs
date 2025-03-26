using System;

class Program
{
    static void Main(string[] args)
    {
        //Create products
        Product product1 = new Product("Laptop", 101, 800, 1);
        Product product2 = new Product("Mouse", 102, 20, 2);
        Product product3 = new Product("Keyboard", 103, 50, 1);

        //Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");

        //Create customers
        Customer customer1 = new Customer("Cheryl Blossom", address1);
        Customer customer2 = new Customer("Archie Andrews", address2);

        //Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        //Display Orders
        Console.WriteLine("========== ORDER 1 ==========");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        // Exibindo detalhes do pedido 2
        Console.WriteLine("========== ORDER 2 ==========");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");

    }
}