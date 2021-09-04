using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTemplateMessage
    {
        public int CodeTemplateMessage { get; set; }
        public string MessageTemplate { get; set; }
        public string TitreDuMessage { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
    }
}
