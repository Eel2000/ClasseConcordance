using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class InscriptionEleve
    {
        public InscriptionEleve()
        {
            BukuDelibeDecisionFinals = new HashSet<BukuDelibeDecisionFinal>();
            BukuEvaluations = new HashSet<BukuEvaluation>();
            BukuNotes = new HashSet<BukuNote>();
            EteyeloAbsences = new HashSet<EteyeloAbsence>();
            EteyeloBulletins = new HashSet<EteyeloBulletin>();
            EteyeloDocuments = new HashSet<EteyeloDocument>();
            EteyeloEleveDetails = new HashSet<EteyeloEleveDetail>();
            EteyeloMouvementEleves = new HashSet<EteyeloMouvementEleve>();
            FinanceCompteEleves = new HashSet<FinanceCompteEleve>();
            FinanceFacturiers = new HashSet<FinanceFacturier>();
            FinancePaiements = new HashSet<FinancePaiement>();
            FinanceSituations = new HashSet<FinanceSituation>();
            GlobalAffectationAdresses = new HashSet<GlobalAffectationAdresse>();
            GlobalEleveParents = new HashSet<GlobalEleveParent>();
            GlobalPresences = new HashSet<GlobalPresence>();
            InscriptionParcours = new HashSet<InscriptionParcour>();
            InscriptionTransferes = new HashSet<InscriptionTransfere>();
        }

        public string NumeroSernieEleve { get; set; }
        public string NumeroPermanent { get; set; }
        public string EloCodeEleve { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public string Sexe { get; set; }
        public DateTime DateNaissance { get; set; }
        public string LieuNaissance { get; set; }
        public string CodeSysClasse { get; set; }
        public bool? EstActif { get; set; }
        public DateTime? DateInscription { get; set; }
        public string ClasseSolliciter { get; set; }
        public string EcoleProvenance { get; set; }
        public decimal? PourcentageAnneePassee { get; set; }
        public string EloCodeEcole { get; set; }
        public string Matricule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<BukuDelibeDecisionFinal> BukuDelibeDecisionFinals { get; set; }
        public virtual ICollection<BukuEvaluation> BukuEvaluations { get; set; }
        public virtual ICollection<BukuNote> BukuNotes { get; set; }
        public virtual ICollection<EteyeloAbsence> EteyeloAbsences { get; set; }
        public virtual ICollection<EteyeloBulletin> EteyeloBulletins { get; set; }
        public virtual ICollection<EteyeloDocument> EteyeloDocuments { get; set; }
        public virtual ICollection<EteyeloEleveDetail> EteyeloEleveDetails { get; set; }
        public virtual ICollection<EteyeloMouvementEleve> EteyeloMouvementEleves { get; set; }
        public virtual ICollection<FinanceCompteEleve> FinanceCompteEleves { get; set; }
        public virtual ICollection<FinanceFacturier> FinanceFacturiers { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
        public virtual ICollection<FinanceSituation> FinanceSituations { get; set; }
        public virtual ICollection<GlobalAffectationAdresse> GlobalAffectationAdresses { get; set; }
        public virtual ICollection<GlobalEleveParent> GlobalEleveParents { get; set; }
        public virtual ICollection<GlobalPresence> GlobalPresences { get; set; }
        public virtual ICollection<InscriptionParcour> InscriptionParcours { get; set; }
        public virtual ICollection<InscriptionTransfere> InscriptionTransferes { get; set; }
    }
}
