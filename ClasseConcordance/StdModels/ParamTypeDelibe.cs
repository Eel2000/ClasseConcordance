using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeDelibe
    {
        public ParamTypeDelibe()
        {
            ParamDelibes = new HashSet<ParamDelibe>();
        }

        public int CodeParamTypeDelibe { get; set; }
        public string Intitule { get; set; }
        public int? CodeAnnee { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<ParamDelibe> ParamDelibes { get; set; }
    }
}
