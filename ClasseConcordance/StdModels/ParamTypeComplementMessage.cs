using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeComplementMessage
    {
        public int CodeTypeComplementMessage { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
    }
}
