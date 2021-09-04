using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class StockCommande
    {
        public string CodeCommande { get; set; }
        public DateTime DateCommande { get; set; }
        public string CodeFournisseur { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public string EloCodeEcole { get; set; }
        public bool? Servie { get; set; }
        public DateTime? DateReception { get; set; }
        public string Observation { get; set; }
    }
}
