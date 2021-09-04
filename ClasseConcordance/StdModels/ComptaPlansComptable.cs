using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ComptaPlansComptable
    {
        public ComptaPlansComptable()
        {
            ComptaClasses = new HashSet<ComptaClass>();
        }

        public string CodePlanCompta { get; set; }
        public string IntitulePlanCompta { get; set; }
        public bool? SyncPush { get; set; }
        public bool? Sync { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<ComptaClass> ComptaClasses { get; set; }
    }
}
