// Represents a product with pricing and quantity information
public class Product
{
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor to initialize product details
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Calculates total cost for this product
    public decimal GetTotalCost()
    {
        return _price * _quantity;  // Price per unit multiplied by quantity
    }

    // Formats product information for labels
    public string GetPackingInfo()
    {
        return $"{_name} (ID: {_productId})";
    }
}