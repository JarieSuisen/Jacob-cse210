using System.Numerics;
using System.Security.Cryptography;

public class Order
{


    // List: a Customer and their ordered products
    List<Product> order = new List<Product>();
    Customer customer = new Customer();

    // Method: Calculate total cost
    private void CalculateProductCosts()
    {
        int orderTotal = 0;
        foreach(Product product in order)
        {
            int productCost = product.CalculateProductCost();
            orderTotal = orderTotal + productCost;

            
        }

        int shippingFee = customer.ShippingFee();

        // // TESTING
        // if (shippingFee == 500)
        // {
        //     Console.WriteLine("SHIPPING IS LOCAL");
        // }
        // else Console.WriteLine("SHIPPING IS NOT LOCAL");
        
        int finalTotal = orderTotal + shippingFee;

        decimal moneyFinalTotal = finalTotal / 100;
        decimal moneyShippingFee = shippingFee / 100;
        decimal moneyOrderTotal = orderTotal / 100;

        // Console.WriteLine($"THIS IS THE ROUNDED TOTAL {moneyFinalTotal.ToString("F")}");
        // decimal.Round(moneyShippingFee, 2, MidpointRounding.AwayFromZero);
        // decimal.Round(moneyOrderTotal, 2, MidpointRounding.AwayFromZero);

        // decimalVar.ToString("F");

        // // Convert to dollar string and return
        // string numberTotal = totalCost.ToString("C");

// FINE WHATEVER, C# can't even show decimal values without ridiculous workarounds. So just using rounded dollar values only. Ugh.

        Console.WriteLine($"Order total: ${moneyOrderTotal}\nShipping Fee: ${moneyShippingFee}\nFinal Total: ${moneyFinalTotal}");


        // return orderTotal;
    }

    // Return string of Packing Label details
    public void GetPackingLabel()
    {

        foreach (Product product in order)
            {
                Console.WriteLine(product.GetProductDetails());
            }

        CalculateProductCosts();


        
        
    }

    // Return string of Shipping Label
    public void GetShippingLabel()
    {
        Console.WriteLine(customer.GetCustomerDetails());

    }

    public void SetOrderDetails
    (
        string customerName,
        string address,
        string city,
        string state,
        string country,
        string product1Name,
        string product1PID,
        int product1Amount,
        int product1Price,
        string product2Name,
        string product2PID,
        int product2Amount,
        int product2Price
    )
    {
        customer.SetCustomerDetails
        (
            customerName,
            address,
            city,
            state,
            country
        );

        Product product1 = new Product();
        product1.SetProductDetails
        (
            product1Name,
            product1PID,
            product1Price,
            product1Amount
        );
        order.Add(product1);

        Product product2 = new Product();
        product2.SetProductDetails
        (
            product2Name,
            product2PID,
            product2Price,
            product2Amount
        );
        order.Add(product2);


    }


    //     total price = sum total of each product plus one-time shipping cost

    //     One-time cost:
    //         IF USA: $5
    //         IF NOT: $35


    // Packing Label: Product Name, Product ID (for each product)
    // Shipping Label: Customer Name, Address





    
}