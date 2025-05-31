// Represents a physical address with validation and formatting capabilities
public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor to initialize address components
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Determines if address is in USA
    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    // Formats address with line breaks
    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}