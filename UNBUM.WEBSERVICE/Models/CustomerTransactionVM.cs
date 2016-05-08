using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class CustomerTransactionVM 
    {
        public int Id { get; set; }
        public string ReferenceNumber { get; set; }
        public int CustomerUserId { get; set; }
        public string CustomerNotes { get; set; }
        public DateTime DateModified { get; set; }
    }
}