using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuTypeEvaluation
    {
        public BukuTypeEvaluation()
        {
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
        }

        public int CodeTypeEvaluation { get; set; }
        public string IntituleTypeEvaluation { get; set; }
        public bool EstExamen { get; set; }
        public string CodeAffClasseAgentCours { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string EloCodeEcole { get; set; }

        public virtual GlobalAffectationClasseAgentCour CodeAffClasseAgentCoursNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
    }
}
