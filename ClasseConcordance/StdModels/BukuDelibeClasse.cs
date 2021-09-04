using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuDelibeClasse
    {
        public string CodeDelibeClasse { get; set; }
        public string CodeClasse { get; set; }
        public string CodeParamDelibe { get; set; }
        public int CodeAnnee { get; set; }
        public string CodeEcole { get; set; }
        public bool? EstActif { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
    }
}
