using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuCour
    {
        public BukuCour()
        {
            BukuNotes = new HashSet<BukuNote>();
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
            GlobalAffectationClasseAgentCours = new HashSet<GlobalAffectationClasseAgentCour>();
            GlobalPresences = new HashSet<GlobalPresence>();
        }

        public string CodeCours { get; set; }
        public string IntituleCours { get; set; }
        public string IntituleCoursCourt { get; set; }
        public int? VolumeHoraire { get; set; }
        public int? MaximaPeriode { get; set; }
        public int? MaximaExamen { get; set; }
        public string CodeSysCours { get; set; }
        public string CodeClasse { get; set; }
        public int? Ponderation { get; set; }
        public string CodeAffClasseAgentCours { get; set; }
        public string CodeTypeCours { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
        public int? Priorite { get; set; }

        public virtual GlobalAffectationClasseAgentCour CodeAffClasseAgentCoursNavigation { get; set; }
        public virtual GlobalClasse CodeClasseNavigation { get; set; }
        public virtual BukuSysCour CodeSysCoursNavigation { get; set; }
        public virtual BukuTypeCour CodeTypeCoursNavigation { get; set; }
        public virtual ICollection<BukuNote> BukuNotes { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual ICollection<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual ICollection<GlobalPresence> GlobalPresences { get; set; }
    }
}
