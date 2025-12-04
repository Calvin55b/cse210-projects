using System;

class Program
{
    static void Main(string[] args)
    {
        //This is to initialize all of the address information
        Address address1 = new Address();

        address1.SetAddress("4827 Maple Ridge Drive", "Boise", "Idaho", "United States");

        address1.GetCountry();

        address1.InUs();

        address1.ShippingPrice();

        //Initialize the customer name

        Customer customer1 = new Customer();
        customer1.SetAddress(address1);
        customer1.SetName("John Steele");
        customer1.GetName();

        //Initialize the order to get the shipping label

        Order order1 = new Order();
        order1.SetCustomer(customer1);
        Console.WriteLine(order1.Shipping());

    }
}