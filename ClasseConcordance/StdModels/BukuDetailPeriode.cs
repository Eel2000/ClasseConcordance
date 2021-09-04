using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class BukuDetailPeriode
    {
        public int CodeDetailPeriode { get; set; }
        public string CodeAnnee { get; set; }
        public string CodePeriode { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamAnneeScolaire CodeDetailPeriodeNavigation { get; set; }
        public virtual GlobalPeriodeScolaire CodePeriodeNavigation { get; set; }
    }
}
