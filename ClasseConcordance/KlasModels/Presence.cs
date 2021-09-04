using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Presence
    {
        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeClasse { get; set; }
        public string CodeEcole { get; set; }
        public DateTime Date { get; set; }
        public string MotifAbsence { get; set; }
        public string Justification { get; set; }
        public bool EstPresent { get; set; }
        public bool? EnRetard { get; set; }
    }
}
