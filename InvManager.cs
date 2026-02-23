using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System;
using System.Net.Http.Headers;

namespace InventorySys_V1
{
    public class InvManager
    {
        // _inventory to store the list of product objects, -filePath is where the inventory json data is stored.
        private List<Product> _inventory = new List<Product>();
        private string _filePath = "inventory.json";
        public InvManager()
        {
            LoadInventory();
        }   
        // deserializing the json format to load existing inventory from file.
        public void LoadInventory()
        {
            if (File.Exists(_filePath))
            {
                string json = File.ReadAllText(_filePath);
                _inventory = JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
            }
        }
        //serializing the inventory to json and writing it to file, this function will be used after every commit
        public void SaveInventory()
        {
            string json = JsonSerializer.Serialize(_inventory, new JsonSerializerOptions {WriteIndented = true});
            File.WriteAllText(_filePath, json);
        }
        public void AddProduct(Product product)
        {
            _inventory.Add(product);
            SaveInventory();
        }
        // overloading is used here to update either quantity or price of product.
        public void UpdateProduct(int id, int quantity)
        {
            Product product = _inventory.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                product.Quantity = quantity;
                SaveInventory();
            }
        }
        public void UpdateProduct(int id, double price)
        {
            Product product = _inventory.FirstOrDefault(p => p.ID == id);
            if (product != null)
            {
                product.Price = price;
                SaveInventory();
            }
        }
        //pop the product with the given ID.
        public void DeleteProduct(int id)
        {
            
                _inventory.RemoveAll(p => p.ID == id);
                SaveInventory();

        }
        // return inventory list so its used in the main func.
        public List<Product> GetAllProducts()
        {
            
            return _inventory;

        } 


    }
} 