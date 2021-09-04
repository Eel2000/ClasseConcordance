using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloCategorieEleve
    {
        public EteyeloCategorieEleve()
        {
            FinanceFrais = new HashSet<FinanceFrai>();
            ParamRegimePaiements = new HashSet<ParamRegimePaiement>();
        }

        public string CodeCategorie { get; set; }
        public string IntituleCategorie { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<FinanceFrai> FinanceFrais { get; set; }
        public virtual ICollection<ParamRegimePaiement> ParamRegimePaiements { get; set; }
    }
}
