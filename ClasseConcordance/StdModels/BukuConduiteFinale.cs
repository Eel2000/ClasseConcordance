using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuConduiteFinale
    {
        public int CodeConduiteFinale { get; set; }
        public string Intitule { get; set; }
        public int ValeurMin { get; set; }
        public int ValeurMax { get; set; }
        public int? CodeAnnee { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
    }
}
