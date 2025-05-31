// Represents a customer with name and address information
public class Customer
{
    private string _name;
    private Address _address;

    // Constructor to initialize customer details
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Checks if customer resides in USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Accessor methods for encapsulation
    public string GetName() => _name;
    public Address GetAddress() => _address;
}