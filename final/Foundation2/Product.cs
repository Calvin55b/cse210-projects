public class Product
{
    
private string _name;

private int _productId;


private double _price;


private int _quantity;


public double GetOrderPrice()
    {
        


        double sumOrder = GetProductPrice() * Getquantity();


        return sumOrder;

    }

public int Getquantity()
    {
        
        return _quantity;

    }

public double GetProductPrice()
    {
        

        return _price;
    }

public string GetProductname()
    {
        


        return _name;
    }


public int GetProductId()
    {
        
        return _productId;

    }



}