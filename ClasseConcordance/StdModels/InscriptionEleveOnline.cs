using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class InscriptionEleveOnline
    {
        public string Code { get; set; }
        public DateTime DateSoumission { get; set; }
        public string CodeEcole { get; set; }
        public string InscriptionInfo { get; set; }
        public bool EstValide { get; set; }
        public string CodeClasse { get; set; }
        public bool? EstAccepter { get; set; }
        public bool EstEffectif { get; set; }
        public string Facturier { get; set; }
        public string InfoPayment { get; set; }
    }
}
