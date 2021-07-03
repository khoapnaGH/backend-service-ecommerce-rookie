using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.DataAccessor.Entities
{
    public class Product: BaseEntityWithAuditTime
    {
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
		public string Images { get; set; }

		public ICollection<ProductCategory> ProductCategories { get; set; }

		public ICollection<ProductRating> ProductRatings { get; set; }

		public OrderItems OrderItems { get; set; }

		public ShoppingCart ShoppingCart { get; set; }
	}
}
