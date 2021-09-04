using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamDevise
    {
        public ParamDevise()
        {
            FinanceCaisses = new HashSet<FinanceCaisse>();
            FinanceCompteBancaires = new HashSet<FinanceCompteBancaire>();
            FinanceCompteEleves = new HashSet<FinanceCompteEleve>();
        }

        public string CodePk { get; set; }
        public string CodeDevise { get; set; }
        public string Symbole { get; set; }
        public string Intitule { get; set; }
        public string Pays { get; set; }
        public bool ParDefaut { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual ICollection<FinanceCaisse> FinanceCaisses { get; set; }
        public virtual ICollection<FinanceCompteBancaire> FinanceCompteBancaires { get; set; }
        public virtual ICollection<FinanceCompteEleve> FinanceCompteEleves { get; set; }
    }
}
