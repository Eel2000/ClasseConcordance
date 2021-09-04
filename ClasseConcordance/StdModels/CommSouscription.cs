using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class CommSouscription
    {
        public string CodeSouscription { get; set; }
        public string CodeParent { get; set; }
        public string CodeAgent { get; set; }
        public string CodeTarif { get; set; }
        public int? Quantite { get; set; }
        public double? MontantDu { get; set; }
        public DateTime? DebutSouscription { get; set; }
        public DateTime? FinSouscritption { get; set; }
        public bool? Etat { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string CodeEcole { get; set; }

        public virtual GlobalAgent CodeAgentNavigation { get; set; }
        public virtual EteyeloEleveDetail CodeParentNavigation { get; set; }
        public virtual CommTarif CodeTarifNavigation { get; set; }
    }
}
