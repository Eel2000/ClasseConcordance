using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceFacturier
    {
        public string CodeFacturier { get; set; }
        public string NumeroFacturier { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodeAnneeScolaire { get; set; }
        public string CodeFrais { get; set; }
        public bool Sync { get; set; }
        public bool? SyncPush { get; set; }

        public virtual InscriptionEleve EloCodeEleveNavigation { get; set; }
    }
}
