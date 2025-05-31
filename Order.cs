// Manages order details including products, customer, and order processing
public class Order
{
    private List<Product> _products;
    private Customer _customer;

    // Constructor initializes order with customer
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    // Adds product to order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Calculates total order cost including shipping
    public decimal CalculateTotalPrice()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();  // Sum product costs
        }
        
        // Add shipping cost based on location
        return total + (_customer.IsInUSA() ? 5 : 35);
    }

    // Generates packing label with product details
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"- {product.GetPackingInfo()}\n";
        }
        return label;
    }

    // Generates shipping label with customer address
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}