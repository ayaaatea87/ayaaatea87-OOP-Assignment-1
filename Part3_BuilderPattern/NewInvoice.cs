public class NewInvoice
{
    // Customer
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }

	// Addresses
	public Address BillingAddress { get; set; }
	public Address ShippingAddress { get; set; }

	// Order 
	public Order Order { get; set; }
	public NewInvoice(
		int invoiceId,
		string customerName,
		string customerEmail,
		string customerPhone,
		Address billingAddress,
		Address shippingAddress,
		Order order)
	{
		InvoiceId = invoiceId;
		CustomerName = customerName;
		CustomerEmail = customerEmail;
		CustomerPhone = customerPhone;

		BillingAddress = billingAddress;
		ShippingAddress = shippingAddress;

		Order = order;
	}

	public override string ToString()
	{
		return $"Invoice ID: {InvoiceId}\n" +
			   $"Customer Name: {CustomerName}\n" +
			   $"Customer Email: {CustomerEmail}\n" +
			   $"Customer Phone: {CustomerPhone}\n\n" +

			   $"Billing Address:\n" +
			   $"  Street: {BillingAddress.Street}\n" +
			   $"  City: {BillingAddress.City}\n" +
			   $"  State: {BillingAddress.State}\n" +
			   $"  Zip Code: {BillingAddress.ZipCode}\n" +
			   $"  Country: {BillingAddress.Country}\n\n" +

			   $"Shipping Address:\n" +
			   $"  Street: {ShippingAddress.Street}\n" +
			   $"  City: {ShippingAddress.City}\n" +
			   $"  State: {ShippingAddress.State}\n" +
			   $"  Zip Code: {ShippingAddress.ZipCode}\n" +
			   $"  Country: {ShippingAddress.Country}\n\n" +

			   $"Order Information:\n" +
			   $"  Order Date: {Order.OrderDate}\n" +
			   $"  Payment Method: {Order.PaymentMethod}\n" +
			   $"  Currency: {Order.Currency}\n" +
			   $"  SubTotal: {Order.SubTotal}\n" +
			   $"  Discount Amount: {Order.DiscountAmount}\n" +
			   $"  Tax Amount: {Order.TaxAmount}\n" +
			   $"  Total Amount: {Order.TotalAmount}";
	}
}


public class NewInvoiceBuilder
{
	private int _invoiceId;
	private string _customerName;
	private string _customerEmail;
	private string _customerPhone;

	private Address _billingAddress;
	private Address _shippingAddress;
	private Order _order;

	public NewInvoiceBuilder(
		int id,
		string name,
		string email,
		string phone)
	{
		_invoiceId = id;
		_customerName = name;
		_customerEmail = email;
		_customerPhone = phone;
	}

	public NewInvoiceBuilder BillingAddress(Address address)
	{
		_billingAddress = address;
		return this;
	}

	public NewInvoiceBuilder ShippingAddress(Address address)
	{
		_shippingAddress = address;
		return this;
	}

	public NewInvoiceBuilder Order(Order order)
	{
		_order = order;
		return this;
	}

	public NewInvoice Build()
	{
		return new NewInvoice(
			_invoiceId,
			_customerName,
			_customerEmail,
			_customerPhone,
			_billingAddress,
			_shippingAddress,
			_order);
	}
}
