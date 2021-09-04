using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalSysClasse
    {
        public GlobalSysClasse()
        {
            GlobalClasses = new HashSet<GlobalClasse>();
            ParamSystemes = new HashSet<ParamSysteme>();
        }

        public string CodeSysClasse { get; set; }
        public int? CodeDegreClasse { get; set; }
        public string CodeOption { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalOption CodeOptionNavigation { get; set; }
        public virtual ICollection<GlobalClasse> GlobalClasses { get; set; }
        public virtual ICollection<ParamSysteme> ParamSystemes { get; set; }
    }
}
