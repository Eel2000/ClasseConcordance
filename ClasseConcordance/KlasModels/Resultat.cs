using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Resultat
    {
        public int Code { get; set; }
        public string KeyResultat { get; set; }
        public string CodePeriode { get; set; }
        public string CodeProfesseur { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public string CodeClasse { get; set; }
        public DateTime? Date { get; set; }
        public bool? EstPublie { get; set; }
        
    }
}
