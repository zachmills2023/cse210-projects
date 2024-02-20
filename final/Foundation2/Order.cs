using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public string GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }

        // Add shipping cost
        if (_customer.LivesInUSA() == true)
        {
        totalCost += 5;
        } 
        else
        {
        totalCost += 35;
        }
        // Return as a string so that the total will be stopped at two decimal places.
        return totalCost.ToString("F2");
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (var product in _products)
        {
            label += product.GetProductDetails() + "\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetName() + "\n" + _customer.GetAddressDetails();
    }
}
