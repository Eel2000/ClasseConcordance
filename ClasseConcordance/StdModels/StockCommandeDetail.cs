using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class StockCommandeDetail
    {
        public string CodeCommandeDetail { get; set; }
        public string CodeArticle { get; set; }
        public string CodeCommande { get; set; }
        public string EloCodeEcole { get; set; }
        public bool? Sync { get; set; }
        public bool? SyncPush { get; set; }
        public int? Quantite { get; set; }
    }
}
