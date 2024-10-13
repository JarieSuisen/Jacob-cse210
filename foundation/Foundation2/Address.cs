public class Address
{


    // Variable: Street Address
    private string _streetAddress = "";
    // Variable: City
    private string _city = "";
    // Variable: State/Province
    private string _state = "";
    // Variable: Country
    private string _country = "";

    // Method: Check if IS/NOT IN US (return Boolean)
    public bool CheckUS()
    {
        bool isInUS = false;
        if (_country == "United States")
        {
            isInUS = true;
        }
        
        return isInUS;
    }

    // method: Return String of Address Details
    public string GetAddressDetails()
    {

        string addressDetails = $"{_streetAddress}\n{_city}, {_state}\n{_country}";

        return addressDetails;
    }

    public void SetAddress(string address, string city, string state, string country)
    {
        _streetAddress = address;
        _city = city;
        _state = state;
        _country = country;

    }


    
}