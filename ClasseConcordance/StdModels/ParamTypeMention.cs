using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeMention
    {
        public string CodeTypeMention { get; set; }
        public string CodeEcole { get; set; }
        public string IntituleMention { get; set; }
        public string IntituleAbregeMention { get; set; }
        public int? ValeurMin { get; set; }
        public int? ValeurMax { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
    }
}
