using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class Parcour
    {
        public string Code { get; set; }
        public string CodeEleve { get; set; }
        public string CodeClasse { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public DateTime DateAffectation { get; set; }
        public bool EstActif { get; set; }
        public string CodeEcole { get; set; }
        //

        public virtual Class CodeClasseNavigation { get; set; }
        public virtual Elefe CodeEleveNavigation { get; set; }
    }
}
