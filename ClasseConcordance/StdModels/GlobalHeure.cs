using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalHeure
    {
        public GlobalHeure()
        {
            GlobalHoraires = new HashSet<GlobalHoraire>();
        }

        public string CodeHeure { get; set; }
        public string Intitule { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }
        public string CodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual GlobalEcole CodeEcoleNavigation { get; set; }
        public virtual ICollection<GlobalHoraire> GlobalHoraires { get; set; }
    }
}
