using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceSituation
    {
        public int CodeSituation { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodeFrais { get; set; }
        public double MontantPaye { get; set; }
        public double MontantDu { get; set; }
        public DateTime DateMaj { get; set; }
        public bool EstSolde { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
