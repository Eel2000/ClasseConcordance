using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamCommission
    {
        public ParamCommission()
        {
            FinanceCommissions = new HashSet<FinanceCommission>();
        }

        public string CodeCommission { get; set; }
        public string Nom { get; set; }
        public decimal? Taux { get; set; }
        public string CodeEcole { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public bool? EstActif { get; set; }
        public double? Montant { get; set; }
        public double? MontantReel { get; set; }
        public string CodeDevise { get; set; }

        public virtual ICollection<FinanceCommission> FinanceCommissions { get; set; }
    }
}
