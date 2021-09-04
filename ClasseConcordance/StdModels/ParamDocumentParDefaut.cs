using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamDocumentParDefaut
    {
        public int CodeDocumentParDefaut { get; set; }
        public string IntituleDocumentParDefaut { get; set; }
        public string CodeTypeDocument { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual EteyeloTypeDocument CodeTypeDocumentNavigation { get; set; }
    }
}
