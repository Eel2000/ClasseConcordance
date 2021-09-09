using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class ResultatElefe
    {
        public int Code { get; set; }
        public double? Pourcentage { get; set; }
        public int? Place { get; set; }
        public int? CodeResultat { get; set; }
        public bool? EstActif { get; set; }
        public string Link { get; set; }
        public string CodeEleve { get; set; }
        
    }
}
