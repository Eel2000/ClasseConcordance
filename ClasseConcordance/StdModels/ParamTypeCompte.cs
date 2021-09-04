using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeCompte
    {
        public ParamTypeCompte()
        {
            ParamComptes = new HashSet<ParamCompte>();
        }

        public int CodeTypeCompte { get; set; }
        public string IntituleCompte { get; set; }
        public string Details { get; set; }
        public bool? PossederPart { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<ParamCompte> ParamComptes { get; set; }
    }
}
