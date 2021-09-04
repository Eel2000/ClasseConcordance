using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalEcole
    {
        public GlobalEcole()
        {
            BukuDelibeCoursSansEchecs = new HashSet<BukuDelibeCoursSansEchec>();
            BukuDelibeDecisionFinals = new HashSet<BukuDelibeDecisionFinal>();
            BukuPartEvaluations = new HashSet<BukuPartEvaluation>();
            BukuSysCours = new HashSet<BukuSysCour>();
            BukuTypeEvaluations = new HashSet<BukuTypeEvaluation>();
            ComptaEcoleClasses = new HashSet<ComptaEcoleClasse>();
            EteyeloMouvementEleves = new HashSet<EteyeloMouvementEleve>();
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinanceCompteBancaires = new HashSet<FinanceCompteBancaire>();
            FinanceFrais = new HashSet<FinanceFrai>();
            FinancePaiements = new HashSet<FinancePaiement>();
            GlobalAffectationAdresses = new HashSet<GlobalAffectationAdresse>();
            GlobalAffectationClasseAgentCours = new HashSet<GlobalAffectationClasseAgentCour>();
            GlobalAffectationLocalClasses = new HashSet<GlobalAffectationLocalClasse>();
            GlobalClasses = new HashSet<GlobalClasse>();
            GlobalCommuniques = new HashSet<GlobalCommunique>();
            GlobalHeures = new HashSet<GlobalHeure>();
            GlobalLocals = new HashSet<GlobalLocal>();
            InscriptionEleves = new HashSet<InscriptionEleve>();
            InscriptionParcours = new HashSet<InscriptionParcour>();
            ParamAffectationSignatureDocuments = new HashSet<ParamAffectationSignatureDocument>();
            ParamAgentFonctions = new HashSet<ParamAgentFonction>();
            ParamDelibes = new HashSet<ParamDelibe>();
            ParamFaitDelibes = new HashSet<ParamFaitDelibe>();
            ParamFonctions = new HashSet<ParamFonction>();
            ParamServices = new HashSet<ParamService>();
            ParamSystemes = new HashSet<ParamSysteme>();
            ParamTemplateOperationCaisses = new HashSet<ParamTemplateOperationCaisse>();
            ParamTypeFrais = new HashSet<ParamTypeFrai>();
        }

        public string NumeroSernie { get; set; }
        public int? CodeReseauEnseignement { get; set; }
        public string CodeAntenne { get; set; }
        public string EloCodeEcole { get; set; }
        public string NomEcole { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public byte[] Sceau { get; set; }
        public byte[] Logo { get; set; }
        public int? CodeTypeEcole { get; set; }
        public string Signatures { get; set; }
        public string CodeEcoleMere { get; set; }
        public string NomEcoleCourt { get; set; }
        public string ProfilEcole { get; set; }
        public string CodeSysScolaire { get; set; }
        public string Domaine { get; set; }
        public string CodePays { get; set; }
        public bool? EstSuperieure { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string ConString { get; set; }
        public string Prefixe { get; set; }
        public string EloCodeEcoleCourt { get; set; }

        public virtual ParamAntenneEcole CodeAntenneNavigation { get; set; }
        public virtual ParamPay CodePaysNavigation { get; set; }
        public virtual ParamReseauEnseignement CodeReseauEnseignementNavigation { get; set; }
        public virtual ParamSystemScolaire CodeSysScolaireNavigation { get; set; }
        public virtual ParamTypeEcole CodeTypeEcoleNavigation { get; set; }
        public virtual ICollection<BukuDelibeCoursSansEchec> BukuDelibeCoursSansEchecs { get; set; }
        public virtual ICollection<BukuDelibeDecisionFinal> BukuDelibeDecisionFinals { get; set; }
        public virtual ICollection<BukuPartEvaluation> BukuPartEvaluations { get; set; }
        public virtual ICollection<BukuSysCour> BukuSysCours { get; set; }
        public virtual ICollection<BukuTypeEvaluation> BukuTypeEvaluations { get; set; }
        public virtual ICollection<ComptaEcoleClasse> ComptaEcoleClasses { get; set; }
        public virtual ICollection<EteyeloMouvementEleve> EteyeloMouvementEleves { get; set; }
        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinanceCompteBancaire> FinanceCompteBancaires { get; set; }
        public virtual ICollection<FinanceFrai> FinanceFrais { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
        public virtual ICollection<GlobalAffectationAdresse> GlobalAffectationAdresses { get; set; }
        public virtual ICollection<GlobalAffectationClasseAgentCour> GlobalAffectationClasseAgentCours { get; set; }
        public virtual ICollection<GlobalAffectationLocalClasse> GlobalAffectationLocalClasses { get; set; }
        public virtual ICollection<GlobalClasse> GlobalClasses { get; set; }
        public virtual ICollection<GlobalCommunique> GlobalCommuniques { get; set; }
        public virtual ICollection<GlobalHeure> GlobalHeures { get; set; }
        public virtual ICollection<GlobalLocal> GlobalLocals { get; set; }
        public virtual ICollection<InscriptionEleve> InscriptionEleves { get; set; }
        public virtual ICollection<InscriptionParcour> InscriptionParcours { get; set; }
        public virtual ICollection<ParamAffectationSignatureDocument> ParamAffectationSignatureDocuments { get; set; }
        public virtual ICollection<ParamAgentFonction> ParamAgentFonctions { get; set; }
        public virtual ICollection<ParamDelibe> ParamDelibes { get; set; }
        public virtual ICollection<ParamFaitDelibe> ParamFaitDelibes { get; set; }
        public virtual ICollection<ParamFonction> ParamFonctions { get; set; }
        public virtual ICollection<ParamService> ParamServices { get; set; }
        public virtual ICollection<ParamSysteme> ParamSystemes { get; set; }
        public virtual ICollection<ParamTemplateOperationCaisse> ParamTemplateOperationCaisses { get; set; }
        public virtual ICollection<ParamTypeFrai> ParamTypeFrais { get; set; }
    }
}
