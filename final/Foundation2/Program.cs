using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("-----ORDER 1-----");
        //This is to initialize all of the address information
        Address address1 = new Address();

        address1.SetAddress("4827 Maple Ridge Drive", "Boise", "Idaho", "United States");

        address1.GetCountry();

        address1.ShippingPrice();

        //Initialize the customer name

        Customer customer1 = new Customer();
        customer1.SetAddress(address1);
        customer1.SetName("John Steele");
        customer1.GetName();

        //I Will now initialize the product

        Product product1 = new Product();

        product1.SetProductInfo("Thunderball 3000", 101, 49.99,2);



        product1.Getquantity();

        product1.GetProductPrice();

        product1.GetOrderPrice();
        Product product2 = new Product();

        product2.SetProductInfo("SolarFlash Lantern", 102,24.50, 4);



        product2.Getquantity();

        product2.GetProductPrice();

        product2.GetOrderPrice();
        //Initialize the order to get the shipping label

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        Console.WriteLine(order1.Shipping());

        Console.WriteLine();

        //Get the packing

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        order1.Packing();

        Console.WriteLine();

        //get total price

        order1.TotalOrderPrice();
        order1.DisplayOrderPrice();

        Console.WriteLine();

        //Start of second order**//

         Console.WriteLine("-----ORDER 2-----");

        //This is to initialize all of the address information
        Address address2 = new Address();

        address2.SetAddress("57 Oak Lantern Avenue", "Brighton", "East Sussex", "United Kingdom");

        address2.GetCountry();

        address2.ShippingPrice();

        //Initialize the customer name

        Customer customer2 = new Customer();
        customer2.SetAddress(address2);
        customer2.SetName("Jessica Vurtuosa");
        customer2.GetName();

        //I Will now initialize the product

        Product product3 = new Product();

        product3.SetProductInfo("UltraGrip Water Bottle", 103, 15.75,1);



        product3.Getquantity();

        product3.GetProductPrice();

        product3.GetOrderPrice();
        Product product4 = new Product();

        product4.SetProductInfo("AeroMax Running Shoes", 104,89.99, 3);



        product4.Getquantity();

        product4.GetProductPrice();

        product4.GetOrderPrice();
        //Initialize the order to get the shipping label

        Order order2 = new Order();
        order2.SetCustomer(customer2);
        Console.WriteLine(order2.Shipping());

        Console.WriteLine();

        //Get the packing

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        order2.Packing();

        Console.WriteLine();

        //get total price

        order2.TotalOrderPrice();
        order2.DisplayOrderPrice();



        


        

    }
}