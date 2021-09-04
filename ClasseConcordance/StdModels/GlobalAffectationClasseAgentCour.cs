using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalAffectationClasseAgentCour
    {
        public GlobalAffectationClasseAgentCour()
        {
            BukuCours = new HashSet<BukuCour>();
            BukuTypeEvaluations = new HashSet<BukuTypeEvaluation>();
            GlobalHoraires = new HashSet<GlobalHoraire>();
        }

        public string CodeAffClasseAgentCours { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? EstActif { get; set; }
        public string EloCodeAgent { get; set; }
        public string CodeAffectationLocalClasse { get; set; }
        public string CodeCours { get; set; }
        public string EloCodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalAffectationLocalClasse CodeAffectationLocalClasseNavigation { get; set; }
        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual BukuCour CodeCoursNavigation { get; set; }
        public virtual GlobalAgent EloCodeAgentNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<BukuCour> BukuCours { get; set; }
        public virtual ICollection<BukuTypeEvaluation> BukuTypeEvaluations { get; set; }
        public virtual ICollection<GlobalHoraire> GlobalHoraires { get; set; }
    }
}
