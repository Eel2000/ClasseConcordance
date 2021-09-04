using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamMamba
    {
        public string CodeMac { get; set; }
        public string NomEcole { get; set; }
        public bool? EstValide { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string EstValideLicence { get; set; }
        public string Quota { get; set; }
        public string CodeEcole { get; set; }
    }
}
