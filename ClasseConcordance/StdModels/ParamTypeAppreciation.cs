using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeAppreciation
    {
        public string CodeTypeAppreciation { get; set; }
        public string CodeEcole { get; set; }
        public string IntituleAppreciation { get; set; }
        public string IntituleAbregeAppreciation { get; set; }
        public int? Valeur { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
    }
}
