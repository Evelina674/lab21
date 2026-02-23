using System;
using lab21.Shipping.Services;
using lab21.CloudStorage.Services;

namespace lab21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== LAB21: Shipping + Cloud Storage (Variant 7) ===");
            Console.WriteLine("Choose system:");
            Console.WriteLine("1 - Shipping");
            Console.WriteLine("2 - Cloud Storage (Variant 7)");
            Console.Write("Your choice: ");

            string? choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                RunShipping();
            }
            else if (choice == "2")
            {
                RunCloud();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine("\nDone. Press any key...");
            Console.ReadKey();
        }

        private static void RunShipping()
        {
            var deliveryService = new DeliveryService();

            Console.WriteLine("--- SHIPPING ---");
            Console.WriteLine("Available types: standard / express / international / night (OCP demo)");
            Console.Write("Enter shipping type: ");

            string? type = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(type))
            {
                Console.WriteLine("Shipping type is required.");
                return;
            }

            Console.Write("Enter distance (km): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal distance) || distance < 0)
            {
                Console.WriteLine("Invalid distance.");
                return;
            }

            Console.Write("Enter weight (kg): ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal weight) || weight < 0)
            {
                Console.WriteLine("Invalid weight.");
                return;
            }

            try
            {
                // Factory creates strategy
                var strategy = ShippingStrategyFactory.Create(type);

                // Service calculates cost using ONLY interface strategy
                decimal cost = deliveryService.CalculateDeliveryCost(distance, weight, strategy);

                Console.WriteLine($"\nShipping cost: {cost}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                Console.WriteLine("Use: standard / express / international / night");
            }
        }

        private static void RunCloud()
        {
            var cloudService = new CloudStorageService();

            Console.WriteLine("--- CLOUD STORAGE (Variant 7) ---");
            Console.WriteLine("Available plans: personal / business / enterprise");
            Console.Write("Enter plan: ");

            string? plan = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(plan))
            {
                Console.WriteLine("Plan is required.");
                return;
            }

            Console.Write("Enter storage (GB): ");
            if (!int.TryParse(Console.ReadLine(), out int storageGb) || storageGb < 0)
            {
                Console.WriteLine("Invalid storage.");
                return;
            }

            Console.Write("Enter users: ");
            if (!int.TryParse(Console.ReadLine(), out int users) || users < 1)
            {
                Console.WriteLine("Invalid users (must be >= 1).");
                return;
            }

            try
            {
                decimal cost = cloudService.CalculateMonthlyCost(plan, storageGb, users);
                Console.WriteLine($"\nMonthly cost: {cost}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
                Console.WriteLine("Use: personal / business / enterprise");
            }
        }
    }
}