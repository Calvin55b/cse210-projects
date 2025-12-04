using System;

class Program
{
    static void Main(string[] args)
    {
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
        //Initialize the order to get the shipping label

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        Console.WriteLine(order1.Shipping());

        Console.WriteLine();

        //Get the packing

        order1.AddProduct(product1);

        order1.Packing();

        Console.WriteLine();

        //get total price

        order1.TotalOrderPrice();
        order1.DisplayOrderPrice();



        


        

    }
}