using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class CommTarif
    {
        public CommTarif()
        {
            CommSouscriptions = new HashSet<CommSouscription>();
        }

        public string CodeTarif { get; set; }
        public double? Montant { get; set; }
        public string CodePeriodicite { get; set; }
        public string CodeService { get; set; }
        public bool? Etat { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual ParamPeriodicite CodePeriodiciteNavigation { get; set; }
        public virtual CommService CodeServiceNavigation { get; set; }
        public virtual ICollection<CommSouscription> CommSouscriptions { get; set; }
    }
}
