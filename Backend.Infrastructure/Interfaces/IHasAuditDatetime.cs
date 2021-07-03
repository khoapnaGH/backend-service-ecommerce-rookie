using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rookie.Infrastructure.Interfaces
{
    public interface IHasAuditDatetime
    {
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}