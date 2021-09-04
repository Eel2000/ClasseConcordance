using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuAppreciation
    {
        public string CodeAppreciation { get; set; }
        public string CodeCours { get; set; }
        public string CodeEleve { get; set; }
        public string CodeTypeAppreciation { get; set; }
        public string CodePeriode { get; set; }
        public int? IntituleAppreciation { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public bool? EstValide { get; set; }
        public string CodeEcole { get; set; }
    }
}
