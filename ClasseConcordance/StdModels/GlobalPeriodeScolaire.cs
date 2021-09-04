using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalPeriodeScolaire
    {
        public GlobalPeriodeScolaire()
        {
            BukuDetailPeriodes = new HashSet<BukuDetailPeriode>();
            BukuEvaluations = new HashSet<BukuEvaluation>();
            BukuNotes = new HashSet<BukuNote>();
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
            EteyeloBulletins = new HashSet<EteyeloBulletin>();
            GlobalPresences = new HashSet<GlobalPresence>();
        }

        public string CodePeriode { get; set; }
        public string IntitulePeriode { get; set; }
        public int? CodeAnnee { get; set; }
        public DateTime? DebutPeriode { get; set; }
        public DateTime? FinPeriode { get; set; }
        public bool? EstActif { get; set; }
        public bool? VisibleUtilisateur { get; set; }
        public int? CodeTypeEcole { get; set; }
        public string CodeTypePeriode { get; set; }
        public int? NiveauPeriode { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual ParamTypeEcole CodeTypeEcoleNavigation { get; set; }
        public virtual ParamTypePeriode CodeTypePeriodeNavigation { get; set; }
        public virtual ICollection<BukuDetailPeriode> BukuDetailPeriodes { get; set; }
        public virtual ICollection<BukuEvaluation> BukuEvaluations { get; set; }
        public virtual ICollection<BukuNote> BukuNotes { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual ICollection<EteyeloBulletin> EteyeloBulletins { get; set; }
        public virtual ICollection<GlobalPresence> GlobalPresences { get; set; }
    }
}
