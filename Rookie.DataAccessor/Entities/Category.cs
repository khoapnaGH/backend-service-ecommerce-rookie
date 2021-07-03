using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rookie.Infrastructure.Interfaces;

namespace Rookie.DataAccessor.Entities
{
    public class Category: BaseEntityWithAuditTime
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
