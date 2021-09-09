using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class AnneeScolaire
    {
        public int Code { get; set; }
        public string Initule { get; set; }
        public DateTime? Debut { get; set; }
        public DateTime? Fin { get; set; }
        public DateTime? DateCreation { get; set; }
        public bool? EstActif { get; set; }
        public string CodeEcole { get; set; }
        //
    }
}
