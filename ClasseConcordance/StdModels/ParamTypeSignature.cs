using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamTypeSignature
    {
        public ParamTypeSignature()
        {
            ParamAffectationSignatureDocuments = new HashSet<ParamAffectationSignatureDocument>();
        }

        public int CodeTypeSignature { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<ParamAffectationSignatureDocument> ParamAffectationSignatureDocuments { get; set; }
    }
}
