namespace ShopFast.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
