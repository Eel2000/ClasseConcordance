using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalAdresse
    {
        public GlobalAdresse()
        {
            GlobalAffectationAdresses = new HashSet<GlobalAffectationAdresse>();
        }

        public string EloCodeAdresse { get; set; }
        public string Ville { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamEntiteAdministrative VilleNavigation { get; set; }
        public virtual ICollection<GlobalAffectationAdresse> GlobalAffectationAdresses { get; set; }
    }
}
