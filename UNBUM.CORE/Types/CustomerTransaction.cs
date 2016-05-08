using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
   public class CustomerTransaction : EntityBase<int>
    {
        public string ReferenceNumber { get; set; }
        public int CustomerUserId { get; set; }
        public int CustomerNotes { get; set; }
        public DateTime DateModified  { get; set; }
        public string ServiceNotes { get; set; }
        public List<CustomerCharges> CustomerCharges { get; set; }
    }
}
