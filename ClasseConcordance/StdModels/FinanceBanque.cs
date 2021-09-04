using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceBanque
    {
        public FinanceBanque()
        {
            FinanceCompteBancaires = new HashSet<FinanceCompteBancaire>();
        }

        public string CodeBanque { get; set; }
        public string IntituleBanque { get; set; }
        public string CodeSwift { get; set; }
        public bool? EstValide { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<FinanceCompteBancaire> FinanceCompteBancaires { get; set; }
    }
}
