public class OrderLine
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public OrderLine(Product product, int quantity)
    {
        Product = product;
        Quantity = quantity;
    }

    public decimal GetTotal()
    {
        return Product.Price * Quantity;
    }
}
