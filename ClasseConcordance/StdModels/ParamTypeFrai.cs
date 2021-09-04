using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeFrai
    {
        public ParamTypeFrai()
        {
            FinanceCompteTypeFrais = new HashSet<FinanceCompteTypeFrai>();
            FinanceFrais = new HashSet<FinanceFrai>();
        }

        public string CodeTypeFrais { get; set; }
        public string IntituleTypeFrais { get; set; }
        public bool? EstActif { get; set; }
        public string EloCodeEcole { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public bool EstInscription { get; set; }
        public bool EstReinscription { get; set; }

        public virtual ParamAnneeScolaire CodeAnneeScolaireNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<FinanceCompteTypeFrai> FinanceCompteTypeFrais { get; set; }
        public virtual ICollection<FinanceFrai> FinanceFrais { get; set; }
    }
}
