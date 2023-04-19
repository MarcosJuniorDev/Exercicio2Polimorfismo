using Exercicio2Polimorfismo.Entities;
using System.Globalization;

namespace Exercicio2Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            List<Product> list = new List<Product>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char ch = char.Parse(Console.ReadLine());
                string name;
                double price;
                switch (ch)
                {
                    case 'i':
                        {
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Customs fee: ");
                            double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            list.Add(new ImportedProduct(name, price, customsFee));
                            break;
                        }
                    case 'u':
                        {
                            Console.Write("Name: ");      
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            Console.Write("Manufacture date (DD/MM/YYYY): ");
                            DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                            list.Add(new UsedProduct(name, price, manufactureDate));
                            break;
                        }
                    case 'c':
                        {
                            Console.Write("Name: ");
                            name = Console.ReadLine();
                            Console.Write("Price: ");
                            price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            list.Add(new Product(name, price));
                            break;
                        }

                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product product in list)
            {
                Console.WriteLine(product.PriceTag());
            }


        }
    }
}