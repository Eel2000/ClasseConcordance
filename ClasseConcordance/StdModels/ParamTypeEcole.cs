using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeEcole
    {
        public ParamTypeEcole()
        {
            GlobalEcoles = new HashSet<GlobalEcole>();
            GlobalPeriodeScolaires = new HashSet<GlobalPeriodeScolaire>();
        }

        public int CodeTypeEcole { get; set; }
        public string IntituleTypeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalEcole> GlobalEcoles { get; set; }
        public virtual ICollection<GlobalPeriodeScolaire> GlobalPeriodeScolaires { get; set; }
    }
}
