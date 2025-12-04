public class Customer
{
    
    private string _customerName;


    private Address _address;


    public void SetAddress(Address address)
    {
        
        _address = address; 
    }
    public Address GetAddress()
    {
        
        return _address;

    }

    public void SetName(string name)
    {
        
        _customerName = name;

    }
    public string GetName()
    {
        
        return _customerName;
    }


}