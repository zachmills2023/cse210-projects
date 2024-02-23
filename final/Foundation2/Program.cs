using System;

class Program
{
    static void Main(string[] args)
    {
        // Create customers
        Customer customer1 = new("Jang Wu", new Address("1272", "Applevale dr", "AK", "USA"));
        Customer customer2 = new("Vishnu Kumar", new Address("456 Elm St", "Othertown", "ON", "Canada"));
        Customer customer3 = new("Biljosef III", new Address("Láland", "5 108", "Reykjavík", "Iceland"));

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Red Rider BB Gun", "RR1", 19.99, 3));
        order1.AddProduct(new Product("Towel", "TW1", 19.99, 12));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Book of Mormon Video Cassetes", "BM1", 14.99, 1));
        order2.AddProduct(new Product("Time Machine", "TM2", 29.99, 2));

        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Black Market Painting", "BM2", 109995.99, 1));
        order3.AddProduct(new Product("Time Machine", "TM2", 29.99, 1));
        order3.AddProduct(new Product("Explosives", "C4", 290.99, 5));

        // Create a list of orders
        List<Order> orders = new List<Order> {order1,order2,order3};

        // Display the information for each order
        foreach (var order in orders)
        {
            Console.WriteLine("Packing Label:");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();

            Console.WriteLine("Shipping Label:");
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine();

            Console.WriteLine("Total Cost:");
            Console.WriteLine("$" + order.GetTotalCost());
            Console.WriteLine();
        }
    }
}