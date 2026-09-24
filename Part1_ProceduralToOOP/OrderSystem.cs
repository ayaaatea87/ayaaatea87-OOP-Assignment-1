public class OrderSystem
{
    private List<Customer> _customers;
    private List<Product> _products;
    private List<Order> _orders;

    public OrderSystem()
    {
        _customers = new List<Customer>();
        _products = new List<Product>();
        _orders = new List<Order>();
    }

    public void AddCustomer(Customer customer)
    {
        _customers.Add(customer);
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }
    public Customer FindCustomer(int id)
    {
        return _customers.FirstOrDefault(x => x.Id == id);
    }
    public Product FindProduct(int id)
    {
        return _products.FirstOrDefault(y => y.Id == id);
    }
    public Order CreateOrder(int orderId, int customerId)
    {
        Customer customer = FindCustomer(customerId);

        if (customer == null)
        {
            return null;
        }

        Order order = new Order(orderId, customer, DateTime.Now);

        _orders.Add(order);

        return order;
    }

    public void AddLineToOrder(int orderId, int productId, int quantity)
    {
        Order order = _orders.FirstOrDefault(o => o.Id == orderId);
        Product product = FindProduct(productId);

        if (order == null || product == null)
        {
            return;
        }

        order.AddLine(product, quantity);
    }

    public void PayOrder(int orderId)
    {
        Order order = _orders.FirstOrDefault(o => o.Id == orderId);

        if (order == null)
        {
            return;
        }

        order.Pay();
    }
    public decimal CalculateTotalSales()
    {
        decimal totalSales = 0;

        foreach (Order order in _orders)
        {
            if (order.IsPaid)
            {
                totalSales += order.CalculateTotal();
            }
        }

        return totalSales;
    }
}
