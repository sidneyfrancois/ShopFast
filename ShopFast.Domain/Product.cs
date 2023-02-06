using System.Collections.Generic;

namespace ShopFast.Domain
{
    public class Product
    {
        public Product()
        {
            this.Clients = new List<Client>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Client> Clients { get; set; }
    }
}
