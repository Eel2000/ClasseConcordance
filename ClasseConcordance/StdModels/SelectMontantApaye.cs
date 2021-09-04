using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.StdModels
{
    public partial class SelectMontantApaye
    {
        public string CodeFrais { get; set; }
        public string CodeTypeFrais { get; set; }
        public string IntituleFrais { get; set; }
        public double MontantAPayer { get; set; }
        public bool? Actif1 { get; set; }
        public string CodeClasse { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string EloCodeEcole { get; set; }
        public decimal? TotalApayeAvecReduct { get; set; }
        public decimal? TotalApayeSansReduct { get; set; }
        public string CodeEleve { get; set; }
        public bool? Actif2 { get; set; }
        public string Codecategorie { get; set; }
    }
}
