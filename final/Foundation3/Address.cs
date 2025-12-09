using System.Dynamic;

public class Address
{
    private string _road;


    private string _city;


    private string _state;

    private string _country;



   public void SetAddi(string road, string city, string state, string country)
    {
        _road = road; 

        _city = city;

        _state = state;

        _country = country;
    }


    public string GetAddi()
    {
        
        return $"{_road}, {_city}, {_state}, {_country}";
    }

        






}