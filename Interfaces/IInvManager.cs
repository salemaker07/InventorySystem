using System.Collections.Generic;

namespace InventorySys_V2
{
    public interface IInvManager
    {
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(int id, int quantity);
        void UpdateProduct(int id, double price);
        List<Product> GetAllProducts();
        void SaveInventory();
        void LoadInventory();
    }
}