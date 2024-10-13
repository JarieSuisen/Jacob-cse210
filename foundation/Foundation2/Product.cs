using System.Numerics;
using System.Reflection.Metadata.Ecma335;

public class Product
{


    // Variable: Name
    private string _productName = "";
    // Variable: Product ID
    private string _productID = "";
    // Variable: Price
    private int _productPrice = 0;
    // Variable: Quantity of each product
    private int _productQuantity = 0;

    // Method: Total cost of item = Price per unit * Quantity
    public int CalculateProductCost()
    {
        int total = _productPrice * _productQuantity;

        // // TESTING
        // Console.WriteLine($"THE TOTAL FOR {_productName} is {total}");

        return total;
    }



    // SETTING VALUES
    public void SetProductDetails(string name, string pID, int price, int quantity)
    {
        _productName = name;
        _productID = pID;
        _productPrice = price;
        _productQuantity = quantity;
    }

    // TESTING TO PROVIDE PRODUCT NAME
    public string GetProductDetails()
    {
        return $"{_productName} ({_productID}): x{_productQuantity}";
    }

    
}