using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalAffectationAdresse
    {
        public string EloCodeAffAdresse { get; set; }
        public string EloCodeAdresse { get; set; }
        public bool? EstActif { get; set; }
        public string EloCodeEcole { get; set; }
        public string EloCodeAgent { get; set; }
        public string EloCodeEleve { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalAdresse EloCodeAdresseNavigation { get; set; }
        public virtual GlobalAgent EloCodeAgentNavigation { get; set; }
        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
