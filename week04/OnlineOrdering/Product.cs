using System;

class Product 
{
    //Setting the variables
    private string _name;
    private int _productId;
    private double _price;
    private int _quantity;

    //Setting constructors
    public Product(string name, int productId, double price, int quantity) 
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }


    //Setting method to compute total cost
    public double GetTotalCost()
    {
        return _price * _quantity;
    }


    //Getters to access the attributes
    public string GetName()
    {
        return _name;
    }

    public int GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}