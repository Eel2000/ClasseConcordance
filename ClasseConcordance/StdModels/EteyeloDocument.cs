using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloDocument
    {
        public string CodeDocument { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodeTypeDocument { get; set; }
        public byte[] FichierDocument { get; set; }
        public DateTime? DateCreation { get; set; }
        public string IntituleDocument { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual EteyeloTypeDocument CodeTypeDocumentNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
