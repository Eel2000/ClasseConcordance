using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalHoraire
    {
        public string CodeHoraire { get; set; }
        public int? CodeJour { get; set; }
        public string CodeHeure { get; set; }
        public bool? EstActif { get; set; }
        public string CodeAffLocalCours { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalAffectationClasseAgentCour CodeAffLocalCoursNavigation { get; set; }
        public virtual GlobalHeure CodeHeureNavigation { get; set; }
        public virtual GlobalJour CodeJourNavigation { get; set; }
    }
}
