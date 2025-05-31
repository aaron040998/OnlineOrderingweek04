// Main program demonstrating online ordering system functionality
class Program
{
    static void Main(string[] args)
    {
        // Create sample addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address canadaAddress = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        
        // Create customers with addresses
        Customer customer1 = new Customer("John Smith", usaAddress);
        Customer customer2 = new Customer("Emma Johnson", canadaAddress);
        
        // Create sample products
        Product product1 = new Product("Laptop", "P1001", 899.99m, 1);
        Product product2 = new Product("Mouse", "P1002", 19.99m, 2);
        Product product3 = new Product("Keyboard", "P1003", 49.99m, 1);
        Product product4 = new Product("Monitor", "P1004", 199.99m, 2);
        
        // Create first order with 3 products
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        
        // Create second order with 3 products
        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        
        // Display order details
        DisplayOrderDetails(order1);
        Console.WriteLine("\n==================================\n");
        DisplayOrderDetails(order2);
    }
    
    // Helper method to display order information
    static void DisplayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalPrice():0.00}");
    }
}