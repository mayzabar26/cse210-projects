using System;

class Address 
{
    //Setting the variables
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    //Setting constructors
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    
    
    //Setting method to check if the country is USA
    public bool IsInUSA()
    {
        return _country.ToUpper() == "USA"; //Returns true if the country is USA 
    }


    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}