using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuDelibeDecisionFinal
    {
        public string CodeDelibeDecision { get; set; }
        public string CodeEleve { get; set; }
        public string CodeAffectationLocalClass { get; set; }
        public int? CodeAnnee { get; set; }
        public string Decision { get; set; }
        public bool? AdmisAuRepechage { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalAffectationLocalClasse CodeAffectationLocalClassNavigation { get; set; }
        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual InscriptionEleve CodeEleveNavigation { get; set; }
    }
}
