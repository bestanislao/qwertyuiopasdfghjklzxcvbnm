using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class RequestService : EntityBase<int>
    {
        public int CustomerTransactionId { get; set; }
        public string CustomerLocation { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public int ServiceType { get; set; }
        public DateTime DateModified { get; set; }  //optional upon request
        public int ModifiedBy { get; set; } //optional upon request
    }
}
