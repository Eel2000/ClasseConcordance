using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalPresence
    {
        public string CodePresence { get; set; }
        public DateTime? Date { get; set; }
        public bool Presence { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodePeriode { get; set; }
        public string MotifAbsence { get; set; }
        public string JustificationAbsence { get; set; }
        public string EloCodeAgent { get; set; }
        public string CodeClasse { get; set; }
        public string CodeCours { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalAffectationLocalClasse CodeClasseNavigation { get; set; }
        public virtual BukuCour CodeCoursNavigation { get; set; }
        public virtual GlobalPeriodeScolaire CodePeriodeNavigation { get; set; }
        public virtual GlobalAgent EloCodeAgentNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
