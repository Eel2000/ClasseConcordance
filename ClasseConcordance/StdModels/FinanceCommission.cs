using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceCommission
    {
        public string CodeFinCommission { get; set; }
        public decimal? Valeur { get; set; }
        public string CodeCommission { get; set; }
        public string CodeEcole { get; set; }
        public DateTime? DateOperation { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodePaiement { get; set; }

        public virtual ParamCommission CodeCommissionNavigation { get; set; }
    }
}
