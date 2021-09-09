using System;
using System.Collections.Generic;

#nullable disable

namespace ClasseConcordance.KlasModels
{
    public partial class CoursClasse
    {
        public string Code { get; set; }
        public string CodeClasse { get; set; }
        public string CodeCours { get; set; }
        public bool EstActif { get; set; }
        public int CodeAnneeScolaire { get; set; }
        public string CodeEcole { get; set; }
        

        public virtual Cour CodeCoursNavigation { get; set; }
    }
}
