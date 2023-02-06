using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopFast.Domain
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
