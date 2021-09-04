using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceCompteTypeFrai
    {
        public string CodeCompteTypeFrais { get; set; }
        public string CodeCompte { get; set; }
        public string CodeTypeFrais { get; set; }
        public DateTime DateAffectation { get; set; }
        public bool EstActif { get; set; }
        public decimal? PartPourcentage { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual ParamCompte CodeCompteNavigation { get; set; }
        public virtual ParamTypeFrai CodeTypeFraisNavigation { get; set; }
    }
}
