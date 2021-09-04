using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceCompteBancaire
    {
        public string CodeCompteBancaire { get; set; }
        public string CodeBanque { get; set; }
        public string IntituleCompteBancaire { get; set; }
        public string NumeroCompte { get; set; }
        public bool? EstValide { get; set; }
        public string CodeDevise { get; set; }
        public string CodeEcole { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual FinanceBanque CodeBanqueNavigation { get; set; }
        public virtual ParamDevise CodeDeviseNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
    }
}
