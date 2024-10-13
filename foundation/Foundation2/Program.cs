using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");

        List<Order> orders = new List<Order>();

        
        // Prices are input in Cents, not dollars. Because everything should be calculated from the lowest value.
        // But they are printed in the dollar value. Because we Americans are obsessed with it.
        // Creates 2+ orders with 2-3 products each.
        //     Call and display:
        //         Packing Label
        //         Shipping Label from Customer Class (calls Address class for address data)
        //         Total Order Price

        // start 2 Orders
        Order order1 = new Order();
        string customername1 = "Kinomoto, Sakura";
        string address1 = "777 North 200 East";
        string city1 = "Tokyo";
        string state1 = "Tokyo";
        string country1 = "Japan";
        string product1Name1 = "Olive Can";
        string product1PID1 = "11052";
        int product1Amount1 = 5;
        int product1Price1 = 503;
        string product2Name1 = "Book of Pixies";
        string product2PID1 = "11028";
        int product2Amount1 = 2;
        int product2Price1 = 1123;

        order1.SetOrderDetails
        (
        customername1,
        address1,
        city1,
        state1,
        country1,
        product1Name1,
        product1PID1,
        product1Amount1,
        product1Price1,
        product2Name1,
        product2PID1,
        product2Amount1,
        product2Price1
        );
        
        Order order2 = new Order();
        string customername2 = "Sepiroth";
        string address2 = "4444 Doom Street";
        string city2 = "Edinwin";
        string state2 = "New York";
        string country2 = "United States";
        string product1Name2 = "Gigantic Sword";
        string product1PID2 = "00001";
        int product1Amount2 = 1;
        int product1Price2 = 500001;
        string product2Name2 = "Fancy Outfit";
        string product2PID2 = "95554";
        int product2Amount2 = 3;
        int product2Price2 = 666666;

        order2.SetOrderDetails
        (
        customername2,
        address2,
        city2,
        state2,
        country2,
        product1Name2,
        product1PID2,
        product1Amount2,
        product1Price2,
        product2Name2,
        product2PID2,
        product2Amount2,
        product2Price2
        );
        




        orders.Add(order1);
        orders.Add(order2);

        Console.Clear();
        foreach (Order order in orders)
        {
            Console.WriteLine("Shipping Label:");
            order.GetShippingLabel();
            Console.WriteLine("");
            Console.WriteLine("Packing Label:");
            order.GetPackingLabel();
            Console.WriteLine("");

        }














    }
}