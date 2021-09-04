using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class ParamPeriodicite
    {
        public ParamPeriodicite()
        {
            CommTarifs = new HashSet<CommTarif>();
        }

        public string CodePeriodicite { get; set; }
        public string Intitule { get; set; }
        public int? Valeur { get; set; }
        public int? NombreSms { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ICollection<CommTarif> CommTarifs { get; set; }
    }
}
