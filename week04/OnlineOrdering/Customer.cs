using System;

class Customer 
{
    //Setting the variables
    private string _name;
    private Address _address;


    //Setting constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    //Setting method to check if the customer is from USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }


    //Setting method to get customer's name
    public string GetName()
    {
        return _name;
    }


    //Setting method to return the object Address
    public Address GetAddress()
    {
        return _address;
    }


    //Setting method to get customer's full address
    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}