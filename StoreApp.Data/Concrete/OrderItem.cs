using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Data.Concrete
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; } = new();

        public int ProductId { get; set; }
        public Product Product { get; set; } = new();

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
