public class Address
{
    
    private string _street;


    private string _city;


    private string _state;


    private string _country;

    private int _shipPrice;

   public void SetAddress(string street,string city, string state, string country)
    {
        

        _street = street;

        _city = city;


        _state = state;


        _country = country;

    }

   public string GetCountry()
    {
        
        return _country;
    }
    public bool InUs()
    {
        
        
        if (_country == "US" || _country == "United States")
        {
            
            
            return true;

        }

        else
        {
           
            return false;
        }

    }    
    public int ShippingPrice()
    {
        
        
        if (_country == "US" || _country == "United States")
        {
            
            
            return _shipPrice +=5;

        }

        else
        {
           
            return _shipPrice += 35;
        }




    }








}