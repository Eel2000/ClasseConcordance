using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinancePaiementOnline
    {
        public string CodePaimentOnline { get; set; }
        public string InfosPaiement { get; set; }
        public string Fournisseur { get; set; }
        public string CodePaiement { get; set; }
        public string CodeEcole { get; set; }
        public bool? EstEffectif { get; set; }
    }
}
