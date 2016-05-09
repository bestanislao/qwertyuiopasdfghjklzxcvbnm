using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UNBUM.WEBSERVICE.Models
{
    public class PaymentVM
    {
        public int Id { get; set; }
        public int CustomerTransactionId { get; set; }
        public decimal CustomerAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Change { get; set; }
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
    }
}