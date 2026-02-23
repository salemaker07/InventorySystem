using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

    

namespace InventorySys_V1
{
     class Program 
    {
        static void Main(string[] args)

        {
            InvManager manager = new InvManager();
            
            
            
            while (true)
            {
            Console.WriteLine("---Welcome to Assal's Inventory System!---");
            Console.WriteLine("---Please select an option:---");
            Console.WriteLine("1. Add a new product / 2. update an existing product / 3. delete a product / 4. view all products  / 5. exit");
            int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    //get the product details and add hem to inventory through the manager class.
                    case 1:
                        Console.WriteLine("Enter product ID:");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter product name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter product price:");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter product quantity:");
                        int quantity = Convert.ToInt32(Console.ReadLine());
                        manager.AddProduct(new Product(id, name, price, quantity));
                        Console.WriteLine("Product added successfully!");
                        break;
                    //ge the product id to update either price ore quantity through overloading.
                    case 2:
                        Console.WriteLine("Enter product ID to update:");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("quantity or price? (q/p)");
                        string updateOption = Console.ReadLine();
                        if (updateOption == "q")
                        {
                            Console.WriteLine("Enter new quantity:");
                            int newQuantity = Convert.ToInt32(Console.ReadLine());
                            manager.UpdateProduct(updateId, newQuantity);
                            Console.WriteLine("Product quantity updated successfully!");
                        }
                        else if (updateOption == "p")
                        {
                            Console.WriteLine("Enter new price:");
                            double newPrice = Convert.ToDouble(Console.ReadLine());
                            manager.UpdateProduct(updateId, newPrice);
                            Console.WriteLine("Product price updated successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid option!");
                 
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter product ID to delete:");
                        int deleted = Convert.ToInt32(Console.ReadLine());
                        manager.DeleteProduct(deleted);
                        Console.WriteLine("Product deleted successfully!");
                        break;
                        //retrieve all products through deserialization
                    case 4 :
                        List<Product> products = manager.GetAllProducts();
                        if (products.Count == 0)
                        {
                            Console.WriteLine("No products in inventory.");
                            break;
                        }
                        Console.WriteLine("ID\tName\tPrice\tQuantity");
                        foreach (Product p in products)
                        {
                            Console.WriteLine($"{p.ID}\t{p.Name}\t{p.Price}\t{p.Quantity}");
                        }
                        break;
                        case 5:
                        Console.WriteLine("Exiting the program. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option! Please try again.");
                        break;
                }

        
            }
        }
    }
}