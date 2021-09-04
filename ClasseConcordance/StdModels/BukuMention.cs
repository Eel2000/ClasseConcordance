using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuMention
    {
        public string CodeMention { get; set; }
        public string CodeClasse { get; set; }
        public string CodeEleve { get; set; }
        public string CodePeriode { get; set; }
        public string CodeSanction { get; set; }
        public string CodeEcole { get; set; }
        public DateTime? DateSanction { get; set; }
        public bool Sync { get; set; }
        public bool SyncPush { get; set; }
    }
}
