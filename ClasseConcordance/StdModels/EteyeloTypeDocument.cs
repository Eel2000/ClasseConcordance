using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloTypeDocument
    {
        public EteyeloTypeDocument()
        {
            EteyeloDocuments = new HashSet<EteyeloDocument>();
            ParamAffectationSignatureDocuments = new HashSet<ParamAffectationSignatureDocument>();
            ParamDocumentParDefauts = new HashSet<ParamDocumentParDefaut>();
        }

        public string CodeTypeDocument { get; set; }
        public string IntituleTypeDocument { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<EteyeloDocument> EteyeloDocuments { get; set; }
        public virtual ICollection<ParamAffectationSignatureDocument> ParamAffectationSignatureDocuments { get; set; }
        public virtual ICollection<ParamDocumentParDefaut> ParamDocumentParDefauts { get; set; }
    }
}
