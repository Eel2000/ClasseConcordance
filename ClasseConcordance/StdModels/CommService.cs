using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class CommService
    {
        public CommService()
        {
            CommTarifs = new HashSet<CommTarif>();
            InverseCodeServiceMereNavigation = new HashSet<CommService>();
        }

        public string CodeService { get; set; }
        public string IntituleService { get; set; }
        public string CodeServiceMere { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual CommService CodeServiceMereNavigation { get; set; }
        public virtual ICollection<CommTarif> CommTarifs { get; set; }
        public virtual ICollection<CommService> InverseCodeServiceMereNavigation { get; set; }
    }
}
