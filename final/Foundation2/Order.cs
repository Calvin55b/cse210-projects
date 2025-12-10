using System.Security.Cryptography.X509Certificates;

public class Order
{
    
    //Attributes//
    private List<Product> _product = new List<Product>();
    private Customer _customer;
    



    
    public double TotalOrderPrice()
    {
        double totalPrice = 0;
        foreach(Product cost in _product)
        {
            
            totalPrice += cost.GetOrderPrice() ;

        }

           

            totalPrice += _customer.GetAddress().ShippingPrice();

        return totalPrice;


    }
    public string Shipping()
    {
        
        return $"--SHIPPING LABEL--\nCustomer name: {_customer.GetName()} - Customer address: {_customer.GetAddress().GetAddress()}";

        

    }

    


    public void Packing()
    {
            Console.WriteLine("--PACKING LABEL--");
        foreach (Product i in _product)
        {
            Console.WriteLine($"Product Name: {i.GetProductname()} - Product ID: {i.GetProductId()}");

        }
       
    

    }

    public void AddProduct(Product p)
    {
        
        _product.Add(p);
    }

    public void DisplayOrderPrice()
    {
        

        Console.WriteLine($"--TOTAL ORDER PRICE--\n [${TotalOrderPrice():F2}]");

    }

    public void SetCustomer(Customer c)
    {
        

        _customer = c;
    }









}