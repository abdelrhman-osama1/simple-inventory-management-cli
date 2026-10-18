List<string> productNames = new List<string>();
List<decimal> productPrices = new List<decimal>();
List<int> productQuantities = new List<int>();

while (true)
{
    Console.WriteLine("1. Add a product");
    Console.WriteLine("2. View products");
    Console.WriteLine("3. delete product");
    Console.WriteLine("4. Exit");
    string?input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("Enter product name:");
            string?name = Console.ReadLine();
            Console.WriteLine("Enter product price:");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter product quantity:");
            int quantity = int.Parse(Console.ReadLine());
            productNames.Add(name);
            productPrices.Add(price);
            productQuantities.Add(quantity);
            break;
        case "2":
            Console.WriteLine("Products:");
            for (int i = 0; i < productNames.Count; i++)
            {
                Console.WriteLine($"{productNames[i]} - ${productPrices[i]} - Quantity: {productQuantities[i]}");
            }
            break;
            case "3":
            Console.WriteLine("Enter the name of the product to delete:");
            string? deleteName = Console.ReadLine();
            int index = productNames.IndexOf(deleteName);
            if (index != -1)
            {
                productNames.RemoveAt(index);
                productPrices.RemoveAt(index);
                productQuantities.RemoveAt(index);
                Console.WriteLine("Product deleted successfully.");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            break;
        case "4":
            return;

            default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }
    
}