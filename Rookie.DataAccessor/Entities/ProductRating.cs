using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rookie.Infrastructure.Interfaces;

namespace Rookie.DataAccessor.Entities
{
    public class ProductRating
    {
        public Guid ProductId { get; set; }
        public Guid CreatorId { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }

        public Product Product { get; set; }
    }
}
