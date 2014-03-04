using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurnamePinMap.Models
{
    interface IAudit
    {
        DateTime Created { get; set; }
        Nullable<DateTime> Modified { get; set; }
    }
}
