using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.DataAccessor.Entities
{
    public class Order: BaseEntity
    {
        public Guid OrderITemId { get; set; }
        public Guid CreatorId { get; set; }
        public decimal TotalPrice { get; set; }
        public Guid CustomerId { get; set; }

        public ICollection<OrderItems> OrderItems { get; set; }

        public Customer Customer { get; set; }
    }
}
