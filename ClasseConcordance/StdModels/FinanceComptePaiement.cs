using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class FinanceComptePaiement
    {
        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeTypeFrais { get; set; }
        public double MontantPaye { get; set; }
        public double? MontantReelPaye { get; set; }
        public DateTime DatePaiement { get; set; }
        public string CodeEcole { get; set; }
        public string CodeAnneeScolaire { get; set; }
        public string CodeTaux { get; set; }
        public string CodeDevise { get; set; }
    }
}
