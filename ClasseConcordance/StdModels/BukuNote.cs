using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuNote
    {
        public string CodeNote { get; set; }
        public string CodePeriode { get; set; }
        public string CodeCours { get; set; }
        public decimal Valeur { get; set; }
        public DateTime? DateCreation { get; set; }
        public string CodeEleve { get; set; }
        public string CodeLocalClasse { get; set; }
        public int? CodeAnnee { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual BukuCour CodeCoursNavigation { get; set; }
        public virtual InscriptionEleve CodeEleveNavigation { get; set; }
        public virtual GlobalPeriodeScolaire CodePeriodeNavigation { get; set; }
    }
}
