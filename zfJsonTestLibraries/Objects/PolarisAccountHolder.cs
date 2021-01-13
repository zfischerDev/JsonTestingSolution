using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zfJsonTestLibraries.Objects
{
    public class PolarisAccountHolder
    {
        public int AccountId { get; set; }
        public Guid AccountGuid { get; set; }
        public string AccountHolder { get; set; }
        public string AccountType { get; set; }
        public List<PolarisTransaction> PolarisTransactions { get; set; }
    }
}
