using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamReseauEnseignement
    {
        public ParamReseauEnseignement()
        {
            GlobalEcoles = new HashSet<GlobalEcole>();
        }

        public int CodeReseau { get; set; }
        public string IntituleReseau { get; set; }
        public string AbreviationReseau { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalEcole> GlobalEcoles { get; set; }
    }
}
