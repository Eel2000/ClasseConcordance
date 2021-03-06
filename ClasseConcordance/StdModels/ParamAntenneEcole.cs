using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamAntenneEcole
    {
        public ParamAntenneEcole()
        {
            GlobalEcoles = new HashSet<GlobalEcole>();
        }

        public string CodeAntenne { get; set; }
        public string IntituleAntenne { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalEcole> GlobalEcoles { get; set; }
    }
}
