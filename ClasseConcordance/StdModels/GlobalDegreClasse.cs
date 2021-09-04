using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalDegreClasse
    {
        public int CodeDegreClasse { get; set; }
        public string IntituleDegreClasse { get; set; }
        public bool? ClasseOrientation { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
    }
}
