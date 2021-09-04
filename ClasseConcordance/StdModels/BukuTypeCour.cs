using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuTypeCour
    {
        public BukuTypeCour()
        {
            BukuCours = new HashSet<BukuCour>();
        }

        public string CodeTypeCours { get; set; }
        public string IntituleTypeCours { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<BukuCour> BukuCours { get; set; }
    }
}
