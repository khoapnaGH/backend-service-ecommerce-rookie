using Rookie.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.DataAccessor.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }

    public abstract class BaseEntityWithAuditTime : BaseEntity, IHasAuditDatetime
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
