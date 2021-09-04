using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalAffectationLocalClasse
    {
        public GlobalAffectationLocalClasse()
        {
            BukuDelibeDecisionFinals = new HashSet<BukuDelibeDecisionFinal>();
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
            GlobalAffectationClasseAgentCours = new HashSet<GlobalAffectationClasseAgentCour>();
            GlobalPresences = new HashSet<GlobalPresence>();
            InscriptionParcours = new HashSet<InscriptionParcour>();
            ParamAffectationDevices = new HashSet<ParamAffectationDevice>();
        }

        public string CodeAffectationLocalClass { get; set; }
        public string CodeClasse { get; set; }
        public string CodeLocal { get; set; }
        public bool? EstActif { get; set; }
        public string Intitule { get; set; }
        public string IntituleCourt { get; set; }
        public string EloCodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual GlobalClasse CodeClasseNavigation { get; set; }
        public virtual GlobalLocal CodeLocalNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<BukuDelibeDecisionFinal> BukuDelibeDecisionFinals { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual ICollection<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual ICollection<GlobalPresence> GlobalPresences { get; set; }
        public virtual ICollection<InscriptionParcour> InscriptionParcours { get; set; }
        public virtual ICollection<ParamAffectationDevice> ParamAffectationDevices { get; set; }
    }
}
