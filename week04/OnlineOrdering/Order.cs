using System;
using System.Collections.Generic;

class Order 
{
    //Setting the variables
    private List<Product> _products;
    private Customer _customer;


    //Setting constructors
    public Order(string text, Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }


    //Setting method: GetTotalCost()
    public double GetTotalCost()
    {
        double total = 0;

        //Sum total cost for each product
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        //Add shipping cost
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        total += shippingCost;
        return total;
    }


    //Setting method: GetPackingLabel()
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }

        return label;
    }


    //Setting method: GetShippingLabel()
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}