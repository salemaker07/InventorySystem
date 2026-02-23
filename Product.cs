
namespace InventorySys_V1
{
    public class Product
    {
        //we used get set to make it accisable and readable to json.
        public int ID { get; set; } 
        public string Name { get; set; } 
        public double Price { get; set; } 
        public int Quantity { get; set; }
        //constructor to initialize the product object.
        public Product(int id, string name, double price, int quantity)
        {
            ID = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        
        

    }
}