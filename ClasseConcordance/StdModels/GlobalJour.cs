using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class GlobalJour
    {
        public GlobalJour()
        {
            GlobalHoraires = new HashSet<GlobalHoraire>();
        }

        public int CodeJour { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<GlobalHoraire> GlobalHoraires { get; set; }
    }
}
