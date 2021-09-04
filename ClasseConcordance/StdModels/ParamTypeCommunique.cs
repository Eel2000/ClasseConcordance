using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeCommunique
    {
        public ParamTypeCommunique()
        {
            GlobalCommuniques = new HashSet<GlobalCommunique>();
        }

        public int CodeTypeComm { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalCommunique> GlobalCommuniques { get; set; }
    }
}
