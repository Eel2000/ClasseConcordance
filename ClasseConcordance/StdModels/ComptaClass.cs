using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ComptaClass
    {
        public ComptaClass()
        {
            ComptaComptes = new HashSet<ComptaCompte>();
            ComptaEcoleClasses = new HashSet<ComptaEcoleClasse>();
        }

        public string CodeClasseCompta { get; set; }
        public int NumClasse { get; set; }
        public string IntituleClasse { get; set; }
        public string CodePlanCompta { get; set; }
        public bool? SyncPush { get; set; }
        public bool? Sync { get; set; }
        public string CodeEcole { get; set; }

        public virtual ComptaPlansComptable CodePlanComptaNavigation { get; set; }
        public virtual ICollection<ComptaCompte> ComptaComptes { get; set; }
        public virtual ICollection<ComptaEcoleClasse> ComptaEcoleClasses { get; set; }
    }
}
