public class Order 
{

    public DateTime OrderDate { get;}
    public string PaymentMethod { get;}
    public string Currency { get; }
    public decimal SubTotal { get;}
	public decimal DiscountAmount { get;}
	public decimal TaxAmount { get;}
	public decimal TotalAmount { get; }

    public Order(DateTime date, string pay, string currency, decimal subtotal, decimal discount, decimal tax, decimal total)
    {
        OrderDate = date;
        PaymentMethod = pay;
        Currency= currency;
        SubTotal = subtotal;
        DiscountAmount = discount;
        TaxAmount = tax;
        TotalAmount = total;
    }
}
public class OrderBulider
{
	private DateTime _orderDate;
	private string _paymentMethod;
	private string _currency;
	private decimal _subTotal;
	private decimal _discountAmount;
	private decimal _taxAmount;
	private decimal _totalAmount;


	public OrderBulider OrderDate(DateTime date)
	{
		_orderDate = date;
		return this;
	}
	public OrderBulider PaymentMethod(string payment)
	{
		_paymentMethod = payment;
		return this;
	}
	public OrderBulider Currency(string currency)
	{
		_currency = currency;
		return this;
	}
	public OrderBulider SubTotal(decimal subtotal)
	{
		_subTotal = subtotal;
		return this;
	}
	public OrderBulider DiscountAmount(decimal discount)
	{
		_discountAmount = discount;
		return this;
	}
	public OrderBulider TaxAmount(decimal tax)
	{
		_taxAmount = tax;
		return this;
	}
	public OrderBulider TotalAmount(decimal total)
	{
		_totalAmount = total;
		return this;
	}

	public Order Build()
	{
		return new Order(_orderDate, _paymentMethod, _currency, _subTotal, _discountAmount, _taxAmount, _totalAmount);
	}
}