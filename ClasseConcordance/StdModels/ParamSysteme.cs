using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamSysteme
    {
        public string CodeParam { get; set; }
        public string EloCodeEcole { get; set; }
        public string CodeSysClasse { get; set; }
        public bool? EstActif { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalSysClasse CodeSysClasseNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
    }
}
