﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zfJsonTestLibraries.Objects
{
    public class PolarisTransaction
    {
        public int TransactionId { get; set; }
        public Guid TransactionGuid { get; set; }
        public Guid AccountGuid { get; set; }
        public string TransactionType { get; set; }
        public decimal BeginningBalance { get; set; }
        public DateTime TransactionDateTime { get; set; }
        public decimal TransactionAmount { get; set; }
        public string Memo { get; set; }
        public decimal EndingBalance { get; set; }
    }
}
