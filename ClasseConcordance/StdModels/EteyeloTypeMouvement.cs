using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class EteyeloTypeMouvement
    {
        public EteyeloTypeMouvement()
        {
            EteyeloMouvementEleves = new HashSet<EteyeloMouvementEleve>();
        }

        public int CodeTypeMouvement { get; set; }
        public string Intitule { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<EteyeloMouvementEleve> EteyeloMouvementEleves { get; set; }
    }
}
