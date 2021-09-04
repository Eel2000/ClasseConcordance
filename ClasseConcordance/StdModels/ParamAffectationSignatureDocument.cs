using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamAffectationSignatureDocument
    {
        public string CodeAffecSignatureDoc { get; set; }
        public string CodeEcole { get; set; }
        public string CodeTypeDocument { get; set; }
        public DateTime? Date { get; set; }
        public bool? Actif { get; set; }
        public string CodeAgent { get; set; }
        public int? CodeSignature { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalAgent CodeAgentNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamTypeSignature CodeSignatureNavigation { get; set; }
        public virtual EteyeloTypeDocument CodeTypeDocumentNavigation { get; set; }
    }
}
