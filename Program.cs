using System;
using System.Net.Http.Headers;
using System.Collections.Generic;

    

namespace InventorySys_V2
{
     class Program 
    {
        public static void Main(string[] args)

        {
            IInvManager manager = new InvManager();
            ConsoleHelper helper = new ConsoleHelper();
            
            
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
                        int id ;
                        List<Product> existingProducts = manager.GetAllProducts();
                        //check if ID already exists.
                        while(true)
                        {
                            id = helper.promptInt("Enter product ID:");
                            if (existingProducts.Exists(p => p.ID == id))
                            {
                                Console.WriteLine("Product ID already exists! Please enter a unique ID.");
                            }
                            else
                            {
                                break;
                            }

                        }
                        string name = helper.prompt("Enter product name:");
                        double price = helper.promptDouble("Enter product price:");
                        int quantity = helper.promptInt("Enter product quantity:");
                        Product newProduct = new Product(id, name, price, quantity);
                        manager.AddProduct(newProduct);
                        Console.WriteLine("Product added successfully!");
                        break;
                    //ge the product id to update either price ore quantity through overloading.
                    case 2:
                        int updateId = helper.promptInt("Enter product ID to update:");
                        List<Product> productsToUpdate = manager.GetAllProducts();
                        //check if product exists before updating.
                        if (productsToUpdate.Exists(p => p.ID == updateId))
                        {
                            //ask user what they want to update.
                         while (true)
                            {
                                Console.WriteLine("What do you want to update? 1. price / 2. quantity / 3. exit");
                                int updateOption = Convert.ToInt32(Console.ReadLine());
                                if (updateOption == 1)
                                {
                                    double newPrice = helper.promptDouble("Enter new price:");
                                    manager.UpdateProduct(updateId, newPrice);
                                    Console.WriteLine("Product price updated successfully!");
                                    break;
                                }
                                else if (updateOption == 2)
                                {
                                    int newQuantity = helper.promptInt("Enter new quantity:");
                                    manager.UpdateProduct(updateId, newQuantity);
                                    Console.WriteLine("Product quantity updated successfully!");
                                    break;
                                }else if (updateOption == 3)
                                {
                                    Console.WriteLine("Update cancelled.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option! Please try again.");
                                }
                            } 
                        } else
                        {
                            Console.WriteLine("Product ID not found! Or have been deleted recently.");
                        }
                       
                        break;
                        
                    case 3:
                        int deleteId = helper.promptInt("Enter product ID to delete:");
                        List<Product> productsToDelete = manager.GetAllProducts();
                        //check if product exists before deleting.
                        if (productsToDelete.Exists(p => p.ID == deleteId))
                        {
                            int sure = helper.promptInt("Are you sure you want to delete this product? 1. yes / 2. no");
                            if (sure == 1)                            {
                                manager.DeleteProduct(deleteId);
                                Console.WriteLine("Product deleted successfully!");
                            } 
                            else if (sure == 2)
                            {                            
                                    Console.WriteLine("Deletion cancelled.");
                            } 
                            else
                            {                             
                                   Console.WriteLine("Invalid option! Please try again.");
                            }   
                            
                        }
                        else
                        {
                            Console.WriteLine("Product ID not found! Or have been deleted recently.");
                        }
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
                        // I didnot commit saveInventory() because I already did previously.
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