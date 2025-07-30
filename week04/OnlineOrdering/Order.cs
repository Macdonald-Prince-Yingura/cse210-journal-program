using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalCost()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        double shipping = _customer.IsInUSA() ? 5 : 35;
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        foreach (Product p in _products)
        {
            sb.AppendLine(p.GetPackingLabel());
        }
        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}
