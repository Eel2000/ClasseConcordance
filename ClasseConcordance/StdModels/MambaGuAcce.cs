using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class MambaGuAcce
    {
        public string CodeGuAcces { get; set; }
        public int? CodeDroit { get; set; }
        public int? CodeGroupUser { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual MambaDroit CodeDroitNavigation { get; set; }
        public virtual MambaGroupUser CodeGroupUserNavigation { get; set; }
    }
}
