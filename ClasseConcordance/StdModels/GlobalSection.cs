using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalSection
    {
        public GlobalSection()
        {
            GlobalOptions = new HashSet<GlobalOption>();
        }

        public string CodeSection { get; set; }
        public string IntituleSection { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }
        public int? CodeNiveau { get; set; }

        public virtual GlobalNiveau CodeNiveauNavigation { get; set; }
        public virtual ICollection<GlobalOption> GlobalOptions { get; set; }
    }
}
