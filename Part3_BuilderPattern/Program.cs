using static Invoice;

namespace Part3_BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new InvoiceBuilder(101, "AYA", "aya03@gmail.com", "010231564")
     .BillingStreet("El Galaa Street")
     .BillingCity("Shibin El Kawm")
     .BillingState("Monufia")
     .BillingZipCode("32511")
     .BillingCountry("Egypt")
     .ShippingStreet("El Galaa Street")
     .ShippingCity("Shibin El Kawm")
     .ShippingState("Monufia")
     .ShippingZipCode("32511")
     .ShippingCountry("Egypt")
     .OrderDate(new DateTime(2026, 9, 20))
     .PaymentMethod("Cash")
     .Currency("EGP")
     .SubTotal(850)
     .DiscountAmount(50)
     .TaxAmount(80)
     .TotalAmount(880)
     .Build();

            Console.WriteLine("default invoice with Builder pattern:");
            Console.WriteLine(invoice);
            Console.WriteLine();
            Console.WriteLine("new voice with composed Builders:");

            Address shipping = new AddressBuilder()
                .Street("El Galaa Street")
                .City("Shibin El Kom")
                .State("Monufia")
                .ZipCode("32511")
                .Country("Egypt")
                .Build();

            Address billing = new AddressBuilder()
                .Street("El Galaa Street")
                .City("Shibin ElKom")
                .State("Monufia")
                .ZipCode("32511")
                .Country("Egypt")
                .Build();

            Order order = new OrderBulider()
                .OrderDate(new DateTime(2026, 9, 20))
                .PaymentMethod("Credit Card")
                .Currency("EGP")
                .SubTotal(1200)
                .DiscountAmount(100)
                .TaxAmount(110)
                .TotalAmount(1210)
                .Build();

            NewInvoice i = new NewInvoiceBuilder(
                    102,
                    "Roaa",
                    "roaa@gmail.com",
                    "01024638")
                .ShippingAddress(shipping)
                .BillingAddress(billing)
                .Order(order)
                .Build();

            Console.WriteLine(i);
        }
    }
}
