using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceFraisRegime
    {
        public string CodeFraisClasseRegime { get; set; }
        public string CodeClasse { get; set; }
        public string CodeRegimePaiement { get; set; }
        public string CodeFrais { get; set; }
        public bool? EstValide { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalClasse CodeClasseNavigation { get; set; }
        public virtual FinanceFrai CodeFraisNavigation { get; set; }
        public virtual ParamRegimePaiement CodeRegimePaiementNavigation { get; set; }
    }
}
