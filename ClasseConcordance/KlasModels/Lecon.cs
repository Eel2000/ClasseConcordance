using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Lecon
    {
        public string Code { get; set; }
        public string Intitule { get; set; }
        public string Contenu { get; set; }
        public string TypeContenu { get; set; }
        public int? CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        public string Illustration { get; set; }
        public string CodeCours { get; set; }
        public DateTime DerniereModification { get; set; }
        public bool EstPubliee { get; set; }
        public Guid Rowguid { get; set; }
    }
}
