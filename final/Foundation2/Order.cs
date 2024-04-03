class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    private decimal _shippingCostUSA = 5;
    private decimal _shippingCostInternational = 35;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

  public decimal GetTotalCost()
{
    decimal totalProductCost = 0;
    foreach (Product product in _products)
    {
        totalProductCost += product.GetTotalCost();
    }

    decimal shippingCost;
    if (_customer.IsInUSA())
    {
        shippingCost = _shippingCostUSA;
    }
    else
    {
        shippingCost = _shippingCostInternational;
    }

    return totalProductCost + shippingCost;
}


    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()}, ID: {product.GetProductId()}\n"; //concatenation of the strings
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress()}";
    }
}
