using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class RaportPaiementBi
    {
        public string IntituleFrais { get; set; }
        public string IntituleTypeFrais { get; set; }
        public string IntituleClasse { get; set; }
        public string FullnameEleve { get; set; }
        public string IntituleCategorieEleve { get; set; }
        public string PostnomEleve { get; set; }
        public string PrenomEleve { get; set; }
        public double? MontantDu { get; set; }
        public double? MontantPaye { get; set; }
        public double? MontantReelPaye { get; set; }
        public string Direction { get; set; }
        public string CodeFrais { get; set; }
        public string EloCodeEleve { get; set; }
        public string CodePaiement { get; set; }
        public string IntituleAnneeScolaire { get; set; }
        public string DeviseDuFrais { get; set; }
        public string DeviseDuPayer { get; set; }
        public DateTime? DatePaiement { get; set; }
        public string SexeEleve { get; set; }
        public string Ecole { get; set; }
        public double? MontantFrais { get; set; }
        public bool? EstActifFrais { get; set; }
        public string EtatEleve { get; set; }
        public double? InfoTauxAppliquerPaiement { get; set; }
    }
}
