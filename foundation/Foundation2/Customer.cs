public class Customer
{


    // Variable: Name (String)
    private string _customerName = "";
    // Variable: Address (via Address Class)
    private Address customerAddress = new Address();
    

    //     Call method in Class:Address to check if IN US or NOT IN US
    public int ShippingFee()
    {
        bool addressCheck = customerAddress.CheckUS();

        int shippingCost;

        if (addressCheck == true)
        {
            shippingCost = 500;
        }
        else
            shippingCost = 3500;

        return shippingCost;
    }

    // SET CUSTOMER DETAILS
    public void SetCustomerDetails(string name, string address, string city, string state, string country)
    {
        _customerName = name;

        customerAddress.SetAddress(address, city, state, country);

    }

    // GET CUSTOMER DETAILS
    public string GetCustomerDetails()
    {
        string shippingAddress = customerAddress.GetAddressDetails();
        string ShippingLabel = $"{_customerName}\n{shippingAddress}";

        return ShippingLabel;
    }
    
}