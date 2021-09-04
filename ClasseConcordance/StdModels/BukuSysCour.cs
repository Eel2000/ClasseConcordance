using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuSysCour
    {
        public BukuSysCour()
        {
            BukuCours = new HashSet<BukuCour>();
        }

        public string CodeSysCours { get; set; }
        public string CodeTypeCours { get; set; }
        public string IntituleSysCours { get; set; }
        public string EloCodeEcole { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public int? Priorite { get; set; }

        public virtual GlobalEcole EloCodeEcoleNavigation { get; set; }
        public virtual ICollection<BukuCour> BukuCours { get; set; }
    }
}
