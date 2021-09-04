using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamCompte
    {
        public ParamCompte()
        {
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinanceCompteFrais = new HashSet<FinanceCompteFrai>();
            FinanceCompteTypeFrais = new HashSet<FinanceCompteTypeFrai>();
        }

        public string CodeCompte { get; set; }
        public int? CodeTypeCompte { get; set; }
        public string IntituleCompte { get; set; }
        public decimal? Part { get; set; }
        public DateTime DateCreation { get; set; }
        public string Type { get; set; }
        public string CodeFrais { get; set; }
        public bool? EstActif { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual FinanceFrai CodeFraisNavigation { get; set; }
        public virtual ParamTypeCompte CodeTypeCompteNavigation { get; set; }
        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinanceCompteFrai> FinanceCompteFrais { get; set; }
        public virtual ICollection<FinanceCompteTypeFrai> FinanceCompteTypeFrais { get; set; }
    }
}
