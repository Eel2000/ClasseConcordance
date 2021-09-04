using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamAnneeScolaire
    {
        public ParamAnneeScolaire()
        {
            BukuDelibeDecisionFinals = new HashSet<BukuDelibeDecisionFinal>();
            BukuEvaluations = new HashSet<BukuEvaluation>();
            BukuNotes = new HashSet<BukuNote>();
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
            ComptaEcoleClasses = new HashSet<ComptaEcoleClasse>();
            EteyeloBulletins = new HashSet<EteyeloBulletin>();
            EteyeloMouvementEleves = new HashSet<EteyeloMouvementEleve>();
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinanceCompteEleves = new HashSet<FinanceCompteEleve>();
            FinanceCompteFrais = new HashSet<FinanceCompteFrai>();
            FinanceCompteTypeFrais = new HashSet<FinanceCompteTypeFrai>();
            FinanceFrais = new HashSet<FinanceFrai>();
            FinancePaiements = new HashSet<FinancePaiement>();
            GlobalAffectationClasseAgentCours = new HashSet<GlobalAffectationClasseAgentCour>();
            GlobalAffectationLocalClasses = new HashSet<GlobalAffectationLocalClasse>();
            GlobalPeriodeScolaires = new HashSet<GlobalPeriodeScolaire>();
            ParamRegimePaiements = new HashSet<ParamRegimePaiement>();
            ParamTypeFrais = new HashSet<ParamTypeFrai>();
        }

        public int CodeAnnee { get; set; }
        public string IntituleAnneeScolaire { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }
        public bool? EstActif { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual BukuDetailPeriode BukuDetailPeriode { get; set; }
        public virtual ICollection<BukuDelibeDecisionFinal> BukuDelibeDecisionFinals { get; set; }
        public virtual ICollection<BukuEvaluation> BukuEvaluations { get; set; }
        public virtual ICollection<BukuNote> BukuNotes { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual ICollection<ComptaEcoleClasse> ComptaEcoleClasses { get; set; }
        public virtual ICollection<EteyeloBulletin> EteyeloBulletins { get; set; }
        public virtual ICollection<EteyeloMouvementEleve> EteyeloMouvementEleves { get; set; }
        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinanceCompteEleve> FinanceCompteEleves { get; set; }
        public virtual ICollection<FinanceCompteFrai> FinanceCompteFrais { get; set; }
        public virtual ICollection<FinanceCompteTypeFrai> FinanceCompteTypeFrais { get; set; }
        public virtual ICollection<FinanceFrai> FinanceFrais { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
        public virtual ICollection<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual ICollection<GlobalAffectationLocalClasse> GlobalAffectationLocalClasses { get; set; }
        public virtual ICollection<GlobalPeriodeScolaire> GlobalPeriodeScolaires { get; set; }
        public virtual ICollection<ParamRegimePaiement> ParamRegimePaiements { get; set; }
        public virtual ICollection<ParamTypeFrai> ParamTypeFrais { get; set; }
    }
}
