using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalCommunique
    {
        public string CodeCommunique { get; set; }
        public DateTime? Date { get; set; }
        public string Objet { get; set; }
        public string Message { get; set; }
        public int? CodeTypeComm { get; set; }
        public string CodeClasse { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string EloCodeEleve { get; set; }

        public virtual GlobalClasse CodeClasseNavigation { get; set; }
        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ParamTypeCommunique CodeTypeCommNavigation { get; set; }
    }
}
