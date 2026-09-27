public class Invoice
{
    // Customer
    public int InvoiceId { get; set; }
    public string CustomerName { get; set; }
    public string CustomerEmail { get; set; }
    public string CustomerPhone { get; set; }

    // Billing address
    public string BillingStreet { get; set; }
    public string BillingCity { get; set; }
    public string BillingState { get; set; }
    public string BillingZipCode { get; set; }
    public string BillingCountry { get; set; }

    // Shipping address
    public string ShippingStreet { get; set; }
    public string ShippingCity { get; set; }
    public string ShippingState { get; set; }
    public string ShippingZipCode { get; set; }
    public string ShippingCountry { get; set; }

    // Order
    public DateTime OrderDate { get; set; }
    public string PaymentMethod { get; set; }
    public string Currency { get; set; }
    public decimal SubTotal { get; set; }
    public decimal DiscountAmount { get; set; }
    public decimal TaxAmount { get; set; }
    public decimal TotalAmount { get; set; }

    public Invoice(
    int invoiceId,
    string customerName,
    string customerEmail,
    string customerPhone,
    string billingStreet,
    string billingCity,
    string billingState,
    string billingZipCode,
    string billingCountry,
    string shippingStreet,
    string shippingCity,
    string shippingState,
    string shippingZipCode,
    string shippingCountry,
    DateTime orderDate,
    string paymentMethod,
    string currency,
    decimal subTotal,
    decimal discountAmount,
    decimal taxAmount,
    decimal totalAmount)
    {
        InvoiceId = invoiceId;
        CustomerName = customerName;
        CustomerEmail = customerEmail;
        CustomerPhone = customerPhone;

        BillingStreet = billingStreet;
        BillingCity = billingCity;
        BillingState = billingState;
        BillingZipCode = billingZipCode;
        BillingCountry = billingCountry;

        ShippingStreet = shippingStreet;
        ShippingCity = shippingCity;
        ShippingState = shippingState;
        ShippingZipCode = shippingZipCode;
        ShippingCountry = shippingCountry;

        OrderDate = orderDate;
        PaymentMethod = paymentMethod;
        Currency = currency;
        SubTotal = subTotal;
        DiscountAmount = discountAmount;
        TaxAmount = taxAmount;
        TotalAmount = totalAmount;
    }

    public override string ToString()
    {
        return $"Invoice ID: {InvoiceId}\n" +
               $"Customer Name: {CustomerName}\n" +
               $"Customer Email: {CustomerEmail}\n" +
               $"Customer Phone: {CustomerPhone}\n" +

               $"Billing Street: {BillingStreet}\n" +
               $"Billing City: {BillingCity}\n" +
               $"Billing State: {BillingState}\n" +
               $"Billing Zip Code: {BillingZipCode}\n" +
               $"Billing Country: {BillingCountry}\n" +

               $"Shipping Street: {ShippingStreet}\n" +
               $"Shipping City: {ShippingCity}\n" +
               $"Shipping State: {ShippingState}\n" +
               $"Shipping Zip Code: {ShippingZipCode}\n" +
               $"Shipping Country: {ShippingCountry}\n" +

               $"Order Date: {OrderDate}\n" +
               $"Payment Method: {PaymentMethod}\n" +
               $"Currency: {Currency}\n" +
               $"SubTotal: {SubTotal}\n" +
               $"Discount Amount: {DiscountAmount}\n" +
               $"Tax Amount: {TaxAmount}\n" +
               $"Total Amount: {TotalAmount}";
    }
} 


    public class InvoiceBuilder
    {
        private int _invoiceId;
        private string _customerName;
        private string _customerEmail;
        private string _customerPhone;


        //optional :
        private string _billingStreet;
        private string _billingCity;
        private string _billingState;
        private string _billingZipCode;
        private string _billingCountry;


        //optional 
        private string _shippingStreet;
        private string _shippingCity;
        private string _shippingState;
        private string _shippingZipCode;
        private string _shippingCountry;


        // Order
        private DateTime _orderDate;
        private string _paymentMethod;
        private string _currency;
        private decimal _subTotal;
        private decimal _discountAmount;
        private decimal _taxAmount;
        private decimal _totalAmount;

        public InvoiceBuilder(int id , string name , string email, string phone )
        {
            _invoiceId = id;
            _customerName= name;
            _customerEmail= email;
            _customerPhone= phone;

        }

        public InvoiceBuilder BillingStreet( string street)
        {
            _billingStreet = street;
            return this;
        }
        public InvoiceBuilder BillingCity( string city )
        {
            _billingCity = city;
            return this;
        }
        public InvoiceBuilder BillingState( string state )
        {
            _billingState = state;
            return this;
        }
        public InvoiceBuilder BillingCountry(string country)
        {
            _billingCountry = country;
            return this;
        }
        public InvoiceBuilder BillingZipCode(string zipCode)
        {
            _billingZipCode = zipCode;
            return this;
        }

        public InvoiceBuilder ShippingStreet(string street)
        {
            _shippingStreet = street;
            return this;
        }
        public InvoiceBuilder ShippingCountry(string country)
        {
            _shippingCountry = country;
            return this;
        }
        public InvoiceBuilder ShippingState(string state)
        {
            _shippingState = state;
            return this;
        }
        public InvoiceBuilder ShippingCity(string city)
        {
            _shippingCity = city;
            return this;
        }
        public InvoiceBuilder ShippingZipCode(string code)
        {
            _shippingZipCode = code;
            return this;
        }

        public InvoiceBuilder OrderDate(DateTime date)
        {
            _orderDate = date;
            return this;
        }
        public InvoiceBuilder PaymentMethod(string payment)
        {
            _paymentMethod = payment;
            return this;
        }
        public InvoiceBuilder Currency(string currency)
        {
            _currency = currency;
            return this;
        }
        public InvoiceBuilder SubTotal(decimal subtotal)
        {
           _subTotal = subtotal;
            return this;
        }
        public InvoiceBuilder DiscountAmount(decimal discount)
        {
            _discountAmount = discount;
            return this;
        }
        public InvoiceBuilder TaxAmount(decimal tax)
        {
            _taxAmount = tax;
            return this;
        }
        public InvoiceBuilder TotalAmount(decimal total)
        {
           _totalAmount = total;
            return this;
        }


        public Invoice Build() 
        {
            return new Invoice(_invoiceId, _customerName, _customerEmail, _customerPhone, _billingStreet ,_billingCity
                , _billingState, _billingZipCode, _billingCountry, _shippingStreet, _shippingCity, _shippingState, _shippingZipCode, _shippingCountry,_orderDate
                , _paymentMethod, _currency, _subTotal, _discountAmount, _taxAmount, _totalAmount);
        }
    }
