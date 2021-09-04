using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuProportionEchecLeger
    {
        public int CodeEchecLeger { get; set; }
        public string Libelle { get; set; }
        public double? Proportion { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
    }
}
