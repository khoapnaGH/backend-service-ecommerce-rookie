using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.DataAccessor.Entities
{
    public class OrderItems: BaseEntity
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Product Products { get; set; }

        public Order Order { get; set; }
    }
}
