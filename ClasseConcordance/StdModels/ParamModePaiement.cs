using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamModePaiement
    {
        public ParamModePaiement()
        {
            FinancePaiements = new HashSet<FinancePaiement>();
        }

        public string CodeModePaiement { get; set; }
        public string IntituleModePaiement { get; set; }
        public bool? EstValide { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
    }
}
