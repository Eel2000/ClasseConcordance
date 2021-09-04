using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamRegimePaiement
    {
        public ParamRegimePaiement()
        {
            FinanceFraisRegimes = new HashSet<FinanceFraisRegime>();
            FinancePaiements = new HashSet<FinancePaiement>();
        }

        public string CodeRegimePaiement { get; set; }
        public DateTime DateAffectation { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public decimal? PourcentagePaiement { get; set; }
        public double? MontantPaiement { get; set; }
        public string CodeCategorieEleve { get; set; }
        public string Intitule { get; set; }
        public bool? EstActif { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual EteyeloCategorieEleve CodeCategorieEleveNavigation { get; set; }
        public virtual ICollection<FinanceFraisRegime> FinanceFraisRegimes { get; set; }
        public virtual ICollection<FinancePaiement> FinancePaiements { get; set; }
    }
}
