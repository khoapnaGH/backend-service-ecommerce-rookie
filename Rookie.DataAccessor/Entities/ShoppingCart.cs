using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.DataAccessor.Entities
{
    public class ShoppingCart
    {
        public Guid ProductId { get; set; }
        public Guid CreatorId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public Product Product { get; set; }
    }
}
