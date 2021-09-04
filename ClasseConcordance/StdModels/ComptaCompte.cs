using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ComptaCompte
    {
        public ComptaCompte()
        {
            InverseCodeComptePereNavigation = new HashSet<ComptaCompte>();
        }

        public string CodeCompte { get; set; }
        public string Intitule { get; set; }
        public string CodeClasseCompta { get; set; }
        public string CodeComptePere { get; set; }
        public bool? SyncPush { get; set; }
        public bool? Sync { get; set; }
        public string CodeEcole { get; set; }

        public virtual ComptaClass CodeClasseComptaNavigation { get; set; }
        public virtual ComptaCompte CodeComptePereNavigation { get; set; }
        public virtual ICollection<ComptaCompte> InverseCodeComptePereNavigation { get; set; }
    }
}
