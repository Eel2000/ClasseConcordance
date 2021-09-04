using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamAffectationDevice
    {
        public string CodeAffDevice { get; set; }
        public string AdresseMac { get; set; }
        public string CodeClasse { get; set; }
        public int? CodeGu { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalAffectationLocalClasse CodeClasseNavigation { get; set; }
        public virtual MambaGroupUser CodeGuNavigation { get; set; }
    }
}
