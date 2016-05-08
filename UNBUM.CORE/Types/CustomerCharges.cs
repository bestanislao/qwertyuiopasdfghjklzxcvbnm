﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class CustomerCharges : EntityBase<int>
    {
        public int CustomerTransactionId { get; set; }
        public int ServiceTypeId { get; set; }
        public string ItemName { get; set; }
        public string ItemCount { get; set; }
        public string ItemDescription { get; set; }
        public decimal ItemPrice { get; set; }
        public decimal TotalAmount  { get; set; }       
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string ComputedDistance { get; set; }  
        public string Remarks { get; set; }
        public int Status { get; set; }
        public DateTime DateModified   { get; set; }

        //public string PictureSelfieFilePath { get; set; }
        //public string PromoCode { get; set; }
    }
}
