public class Order
{
    public int Id { get; set; }
    public Customer Customer { get; set; }
    public DateTime Date { get; set; }
    public bool IsPaid { get; private set; }

    public List<OrderLine> Lines { get; set; }

    public Order(int id, Customer customer, DateTime date)
    {
        Id = id;
        Customer = customer;
        Date = date;
        IsPaid = false;
        Lines = new List<OrderLine>();
    }

    public void AddLine(Product product, int quantity)
    {
        Lines.Add(new OrderLine(product, quantity));
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;

        foreach (OrderLine line in Lines)
        {
            total += line.GetTotal();
        }

        if (Customer.IsVip)
        {
            total *= 0.90m;
        }

        return total;
    }

    public void Pay()
    {
        IsPaid = true;
    }
}