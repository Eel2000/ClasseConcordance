using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamFaitDelibe
    {
        public string CodeFaitDelibe { get; set; }
        public string Decision { get; set; }
        public string DecisionAbregee { get; set; }
        public string CodeEcole { get; set; }
        public int? Priorite { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
    }
}
