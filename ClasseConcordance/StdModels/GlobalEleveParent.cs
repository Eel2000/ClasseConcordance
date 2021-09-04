using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalEleveParent
    {
        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeParent { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual InscriptionEleve CodeEleveNavigation { get; set; }
        public virtual GlobalParent CodeParentNavigation { get; set; }
    }
}
