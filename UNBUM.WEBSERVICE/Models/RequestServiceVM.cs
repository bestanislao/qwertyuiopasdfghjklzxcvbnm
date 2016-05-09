using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class RequestServiceVM
    {
        public int Id { get; set; }
        public int CustomerTransactionId { get; set; }
        public string TransactionReferenceNumber { get; set; }
        public string CustomerLocation { get; set; }
        public DateTime DateCreated { get; set; }
        public int Status { get; set; }
        public int ServiceType  { get; set; }
        public DateTime DateModified { get; set; }  //optional upon request
        public int ModifiedBy { get; set; } //optional upon request
    }
}