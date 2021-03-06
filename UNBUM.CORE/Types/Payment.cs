﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNBUM.CORE.Types
{
    public class Payment : EntityBase<int>
    {
        public int CustomerTransactionId { get; set; }
        public decimal CustomerAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal Change { get; set; }
        public DateTime DateModified { get; set; }
        public int CreatedBy { get; set; }
    }
}
