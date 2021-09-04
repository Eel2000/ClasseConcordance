using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalFiliere
    {
        public GlobalFiliere()
        {
            GlobalClasses = new HashSet<GlobalClasse>();
        }

        public string CodeFiliere { get; set; }
        public string IntituleFiliere { get; set; }
        public bool? EstActif { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalClasse> GlobalClasses { get; set; }
    }
}
