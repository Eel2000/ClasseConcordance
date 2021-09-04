using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class MambaLog
    {
        public int CodeLog { get; set; }
        public string CodeUtilisateur { get; set; }
        public string CodeOperation { get; set; }
        public string TablesAffecter { get; set; }
        public string Value { get; set; }
        public DateTime? DateLog { get; set; }
        public string NomEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual MambaUtilisateur CodeUtilisateurNavigation { get; set; }
    }
}
