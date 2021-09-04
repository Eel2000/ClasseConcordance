using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalLocal
    {
        public GlobalLocal()
        {
            GlobalAffectationLocalClasses = new HashSet<GlobalAffectationLocalClasse>();
        }

        public string CodeLocal { get; set; }
        public string IntituleLocal { get; set; }
        public int? NombrePlace { get; set; }
        public string Localisation { get; set; }
        public string EloCodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<GlobalAffectationLocalClasse> GlobalAffectationLocalClasses { get; set; }
    }
}
