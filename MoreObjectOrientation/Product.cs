namespace MoreObjectOrientation
{
    public class Product
    {
        public string Id { get; private set; }
        public int Price { get; private set; }
        public string ItemName { get; private set; }

        public Product(string id, int price, string itemName)
        {
            Id = id;
            Price = price;
            ItemName = itemName;
        }
       
    }
}