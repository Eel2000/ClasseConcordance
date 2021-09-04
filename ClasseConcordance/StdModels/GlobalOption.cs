using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalOption
    {
        public GlobalOption()
        {
            GlobalSysClasses = new HashSet<GlobalSysClasse>();
        }

        public string CodeOption { get; set; }
        public string IntituleOption { get; set; }
        public string CodeSection { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalSection CodeSectionNavigation { get; set; }
        public virtual ICollection<GlobalSysClasse> GlobalSysClasses { get; set; }
    }
}
