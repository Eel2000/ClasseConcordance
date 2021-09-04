using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuPartEvaluation
    {
        public BukuPartEvaluation()
        {
            BukuEvaluations = new HashSet<BukuEvaluation>();
        }

        public string CodePartEvaluation { get; set; }
        public int Part { get; set; }
        public string CodeCours { get; set; }
        public string CodeAffectationLocalClass { get; set; }
        public int? CodeTypeEvaluation { get; set; }
        public string CodePeriode { get; set; }
        public int? CodeAnnee { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalAffectationLocalClasse CodeAffectationLocalClassNavigation { get; set; }
        public virtual ParamAnneeScolaire CodeAnneeNavigation { get; set; }
        public virtual BukuCour CodeCoursNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual GlobalPeriodeScolaire CodePeriodeNavigation { get; set; }
        public virtual BukuTypeEvaluation CodeTypeEvaluationNavigation { get; set; }
        public virtual ICollection<BukuEvaluation> BukuEvaluations { get; set; }
    }
}
