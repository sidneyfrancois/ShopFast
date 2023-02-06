using System.Collections.Generic;

namespace ShopFast.Domain
{
    class Client
    {
        public Client()
        {
            this.Products = new List<Product>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
