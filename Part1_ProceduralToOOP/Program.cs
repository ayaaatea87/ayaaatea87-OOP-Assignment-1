namespace Part1_ProceduralToOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrderSystem system = new OrderSystem();

            while (true)
            {
                Console.WriteLine("\n--- Order System ---");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Product");
                Console.WriteLine("3. Create Order");
                Console.WriteLine("4. Add Product To Order");
                Console.WriteLine("5. Pay Order");
                Console.WriteLine("6. Total Sales");
                Console.WriteLine("0. Exit");

                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddCustomer(system);
                        break;

                    case "2":
                        AddProduct(system);
                        break;

                    case "3":
                        CreateOrder(system);
                        break;

                    case "4":
                        AddLine(system);
                        break;

                    case "5":
                        PayOrder(system);
                        break;

                    case "6":
                        Console.WriteLine($"Total Sales: {system.CalculateTotalSales()}");
                        break;

                    case "0":
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddCustomer(OrderSystem system)
        {
            Console.Write("Customer ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("Is VIP? (true/false): ");
            bool isVip = bool.Parse(Console.ReadLine());

            Customer customer = new Customer(id, name, email, city, isVip);

            system.AddCustomer(customer);

            Console.WriteLine("Customer added successfully.");
        }

        static void AddProduct(OrderSystem system)
        {
            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Stock: ");
            int stock = int.Parse(Console.ReadLine());

            Product product = new Product(id, name, price, stock);

            system.AddProduct(product);

            Console.WriteLine("Product added successfully.");
        }

        static void CreateOrder(OrderSystem system)
        {
            Console.Write("Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            Console.Write("Customer ID: ");
            int customerId = int.Parse(Console.ReadLine());

            Order order = system.CreateOrder(orderId, customerId);

            if (order == null)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            Console.WriteLine("Order created successfully.");
        }

        static void AddLine(OrderSystem system)
        {
            Console.Write("Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            system.AddLineToOrder(orderId, productId, quantity);

            Console.WriteLine("Product added to order.");
        }

        static void PayOrder(OrderSystem system)
        {
            Console.Write("Order ID: ");
            int orderId = int.Parse(Console.ReadLine());

            system.PayOrder(orderId);

            Console.WriteLine("Order paid successfully.");
        }
    }
}
