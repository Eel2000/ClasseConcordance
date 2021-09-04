using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceFrai
    {
        public FinanceFrai()
        {
            FinanceCompteEleves = new HashSet<FinanceCompteEleve>();
            FinanceCompteFrais = new HashSet<FinanceCompteFrai>();
            FinanceFraisRegimes = new HashSet<FinanceFraisRegime>();
            ParamComptes = new HashSet<ParamCompte>();
        }

        public string CodeFrais { get; set; }
        public string CodeTypeFrais { get; set; }
        public string IntituleFrais { get; set; }
        public double MontantAPayer { get; set; }
        public DateTime DebutPaiement { get; set; }
        public DateTime FinPaiement { get; set; }
        public DateTime? RetardPaiement { get; set; }
        public DateTime? DateCreation { get; set; }
        public string CodeCategorie { get; set; }
        public bool? EstActif { get; set; }
        public string CodeClasse { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string EloCodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public bool? EstPayableMultiple { get; set; }
        public string CodePk { get; set; }
        public string CodeArticle { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual EteyeloCategorieEleve CodeCategorieNavigation { get; set; }
        public virtual GlobalClasse CodeClasseNavigation { get; set; }
        public virtual ParamTypeFrai CodeTypeFraisNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<FinanceCompteEleve> FinanceCompteEleves { get; set; }
        public virtual ICollection<FinanceCompteFrai> FinanceCompteFrais { get; set; }
        public virtual ICollection<FinanceFraisRegime> FinanceFraisRegimes { get; set; }
        public virtual ICollection<ParamCompte> ParamComptes { get; set; }
    }
}
