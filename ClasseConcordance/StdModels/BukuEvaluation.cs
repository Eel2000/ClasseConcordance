using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuEvaluation
    {
        public string CodeEvaluation { get; set; }
        public string CodePartEvaluation { get; set; }
        public int? MaximaEvaluation { get; set; }
        public decimal? Valeur { get; set; }
        public string CodePeriode { get; set; }
        public string CodeEleve { get; set; }
        public bool? EstActif { get; set; }
        public int? CodeAnnee { get; set; }
        public int? NumeroOrdre { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual InscriptionEleve CodeEleveNavigation { get; set; }
        public virtual BukuPartEvaluation CodePartEvaluationNavigation { get; set; }
        public virtual GlobalPeriodeScolaire CodePeriodeNavigation { get; set; }
    }
}
