using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class MambaDroit
    {
        public MambaDroit()
        {
            MambaGuAcces = new HashSet<MambaGuAcce>();
        }

        public int CodeDroit { get; set; }
        public string IntituleDroit { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<MambaGuAcce> MambaGuAcces { get; set; }
    }
}
